using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _timerAlcohol : MonoBehaviour
{
    Image BarraTiempo;
    public float TiempoDeJeugo = 10;                    //TIEMPO DE JUEGO ES 10 SEGUNDO PREDETERMINADAMENTE
    float TiempoRestante;                               //TIEMPO QUE QUEDA
    public Text TextoPerder;                      //PONER TEXTO DE PERDER
    public float _otroTimer = 3f;


    public bool Jugando;                                //REVISA SI AUN ESTA JUGANDO

    // Start is called before the first frame update
    void Start()
    {
        BarraTiempo = GetComponent<Image>();            //AGGARA EL SPRITE DEL TIEMPO
        TiempoRestante = TiempoDeJeugo - Vida.ResterTiempo;                 //SE ASIGNA EL TIEMPO
        TiempoDeJeugo = TiempoRestante;
        Jugando = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (TiempoRestante > 0 && Jugando == true)        //LO QUE SUCEDE MIENTRAS AUN HAY TIEMPO
        {
            TiempoRestante -= 1 * Time.deltaTime;
            BarraTiempo.fillAmount = TiempoRestante / TiempoDeJeugo;
        }

        if (TiempoRestante <= 0 && Jugando == true)      //LO QUE SUCEDE CUANDO SE ACAVA EL TIEMPO
        {
            Jugando = false;
            Perder();
            
        }
        _otroTimer -= 1 * Time.deltaTime;

        if (_otroTimer <= 0)
        {
            _otroTimer = 0;
            Jugando = true;
        }
    }

    public void Ganar()
    {
        Jugando = false;
    }

    public void Perder()                                   //LO QUE SUCEDE CUANDO PIERDES
    {        
        TextoPerder.text = "Tiempo!";
        AuidoScript.instance.Mute("AlcoholEff");
        FindObjectOfType<Botella_Script>()._Perder();
        FindObjectOfType<Player_Script>()._Perder();
        StartCoroutine(waitaSec());
    }

    public void VolveraInicio()
    {
        SceneManager.LoadScene("Sc_MainMenu");
    }

    IEnumerator waitaSec()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Sc_Perder");
    }
}
