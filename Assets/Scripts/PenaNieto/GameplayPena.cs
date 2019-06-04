using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayPena : MonoBehaviour
{
    public Text textoPregunta;
    public Text Num2;
    public Text Num3;
    public Text Resultado;

    public GameObject mecanica;
    public GameObject instruccion;
    public GameObject boton1;
    public GameObject boton2;
    public GameObject tiempo;

    //------------------------------

    public float volumen = .5f;
    int retoCont;

    //---------------------------
    Vector3 Bandera;

    //-------------------------------
    public float delay = 0.1f;
    private string currentText = "";
    string pregunta;

    IEnumerator ShowText()
    {
        for (int i = 0; i < pregunta.Length; i++)
        {
            currentText = pregunta.Substring(0, i);
            textoPregunta.text = currentText;
            yield return new WaitForSeconds(delay);

        }
        tiempo.SetActive(!tiempo.activeSelf);                   //inicia la barra de tiempo despues de acabar de escribir la pregunta
        boton1.SetActive(!boton1.activeSelf);
        boton2.SetActive(!boton2.activeSelf);

       
        posicionRandom();
    }

    //-----------------------------

    int num1;
    int num2;
    int num3;

    void Start()
    {
      //PlayerPrefs.SetInt("Peña_Contador", 0);
        retoCont = PlayerPrefs.GetInt("Peña_Contador");
        Invoke("DarValoresABotones", 2);                            //tiempo antes de que empiece el juego 
        
        AuidoScript.instance.Play("IntroGameEff");
        AuidoScript.instance.Set_Volume("Marcha", 0.25f);

        if (PlayerPrefs.GetInt("Peña_Contador") >= 50)
        {
            PlayerPrefs.SetInt("Colecionable_5", 1);
        }

    }

    int sacaRandom(int _min, int _max)
    {
        int numRandom;
        numRandom = Random.Range(_min, _max);
        //Debug.Log(numRandom);
        return numRandom;
    }


    void posicionRandom()
    {
        int ranPosition = sacaRandom(1, 3);
        //ranPosition = 2;
        Debug.Log(ranPosition);
        if (ranPosition == 1)
        {
            Bandera = boton1.transform.position;
            boton1.transform.position = boton2.transform.position;
            boton2.transform.position = Bandera;
        }
        else{ }
    }

    void DarValoresABotones()
    {
        mecanica.SetActive(!mecanica.activeSelf);                       //quita los letreros despues del tiempo decidido en start
        instruccion.SetActive(!instruccion.activeSelf);
        
       
        

        num1 = sacaRandom(5,10);                                        //saca los valores de los numeros
        num2 = sacaRandom(num1+1, 15);
        num3 = sacaRandom(0, num1-1);

        Num2.text = num2.ToString();
        Num3.text = num3.ToString();

        pregunta = "Estamos a " + num1 + " minutos de aterrizar, no, menos, como a...";
        StartCoroutine(ShowText());                                     //escribe la pregunta letra por letra

                                                  //Audio
        AuidoScript.instance.Play("Pizarron");
        
    }

    public void Ganaste()
    {
        retoCont++;
        PlayerPrefs.SetInt("Peña_Contador", retoCont);
        Debug.Log(PlayerPrefs.GetInt("Peña_Contador"));
        tiempo.SetActive(!tiempo.activeSelf);
        Resultado.text = "Correcto";
        Invoke("cambiaEscenaGanar", 1);
        
    }
    public void Pediste()
    {
        tiempo.SetActive(!tiempo.activeSelf);
        Resultado.text = "Incorrecto";
        Invoke("cambiaEscenaPerder", 1);
    }

    void cambiaEscenaGanar()
    {

        SceneManager.LoadScene("Sc_Ganar");
    }
    void cambiaEscenaPerder()
    {
        SceneManager.LoadScene("Sc_Perder");
    }

    /*  
     float f = 13.5f;
string s = f.ToString("R");
     */
}
