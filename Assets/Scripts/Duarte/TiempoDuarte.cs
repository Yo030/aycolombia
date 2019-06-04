using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TiempoDuarte : MonoBehaviour
{
    Image BarraTiempo;
    public float TiempoDeJeugo = 10;                    //TIEMPO DE JUEGO ES 10 SEGUNDO PREDETERMINADAMENTE
    float TiempoRestante;                               //TIEMPO QUE QUEDA
    public Text TextoPerder;                      //PONER TEXTO DE PERDER



    // Start is called before the first frame update
    void Awake()
    {
        BarraTiempo = GetComponent<Image>();            //AGGARA EL SPRITE DEL TIEMPO
        TiempoRestante = TiempoDeJeugo - Vida.ResterTiempo;                 //SE ASIGNA EL TIEMPO
        TiempoDeJeugo = TiempoRestante;
    }

    // Update is called once per frame
    void Update()
    {
        if (TiempoRestante > 0)        //LO QUE SUCEDE MIENTRAS AUN HAY TIEMPO
        {
            TiempoRestante -= 1 * Time.deltaTime;
            BarraTiempo.fillAmount = TiempoRestante / TiempoDeJeugo;
        }

        if (TiempoRestante <= 0)      //LO QUE SUCEDE CUANDO SE ACAVA EL TIEMPO
        {

            Perder();
        }
    }

    public void Ganar()
    {
        AuidoScript.instance.Stop("SirensEff");
        TextoPerder.text = "Ganador";
        SceneManager.LoadScene("Sc_Ganar");
    }

    public void Perder()                                   //LO QUE SUCEDE CUANDO PIERDES
    {
        AuidoScript.instance.Stop("SirensEff");
        SceneManager.LoadScene("Sc_Perder");

    }

    public void VolveraInicio()
    {
        SceneManager.LoadScene("Sc_MainMenu");
    }
}
