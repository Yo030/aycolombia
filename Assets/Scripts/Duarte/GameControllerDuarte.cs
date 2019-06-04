using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControllerDuarte : MonoBehaviour
{

    public Text Txt_mecanica;
    public Text Txt_instruccion;
    public Text Txt_resultado;
    public GameObject Tiempo;
    public GameObject policiasYdinero;
    int cantidadPolicias = 4;
    int cantidadDinero = 6;



    void Start()
    {
        AuidoScript.instance.Play("SirensEff");
        //AuidoScript.instance.Play("EructoEff");

        int DineroRestante = cantidadDinero;
        Invoke("quitarIntrucciones", 2);
      //  Invoke("CrearDinero", 2);
      //  Invoke("CrearPolicias", 2);

    }
    


    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "Policia")
        {
            Destroy(coll.gameObject);
            Perdiste();
            
        }
        if (coll.name == "Dinero")
        {
            Debug.Log("Dinero");
            Destroy(coll.gameObject);
            cantidadDinero--;
            AuidoScript.instance.Play("ComerDineroEff");
        }
    }

    private void Update()
    {
        if (cantidadDinero <= 0)
        {
            //AuidoScript.instance.Play("EructoEff");
            Ganaste();
        }
    }
    //*********************************
    void quitarIntrucciones()
    {
        Txt_mecanica.text = "";
        Txt_instruccion.text = "";
        Tiempo.SetActive(!Tiempo.activeSelf);
        policiasYdinero.SetActive(!policiasYdinero.activeSelf);
    }

    public void Ganaste()
    {
        AuidoScript.instance.Play("EructoEff");

        policiasYdinero.SetActive(false);
        Tiempo.SetActive(false);
        Txt_resultado.text = "Ganaste";

        AuidoScript.instance.Stop("SirensEff");
        

        StartCoroutine(waitaSec());


    }

    public void Perdiste()
    {
        policiasYdinero.SetActive(!policiasYdinero.activeSelf);
        Tiempo.SetActive(!Tiempo.activeSelf);

        AuidoScript.instance.Stop("SirensEff");

        Txt_resultado.text = "Perdiste";
        Invoke("escenaPerder", 1);
        
    }


    public void escenaGanar()
    {
        SceneManager.LoadScene("Sc_Ganar");
    }

    public void escenaPerder()
    {
        SceneManager.LoadScene("Sc_Perder");
    }
    //**********************************

    IEnumerator waitaSec()
    {
        //AuidoScript.instance.Play("EructoEff");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Sc_Ganar");
    }

}
