using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLimit : MonoBehaviour {

    Image BarraTiempo;
    public float TiempoDeJeugo = 10;                    //TIEMPO DE JUEGO ES 10 SEGUNDO PREDETERMINADAMENTE
    float TiempoRestante;                               //TIEMPO QUE QUEDA
    public GameObject TextoPerder;                      //PONER TEXTO DE PERDER

    public string NombreObjeto = " ";                    //NOMBRE DEL OBJETO QUE TIENE EL CONTROLADOR DEL JUEGO
    Movimiento Controlador;                               //PONER SCRIPT DEL CONTROLADOR DEL JUEGO

    
    public bool Jugando = true;                                //REVISA SI AUN ESTA JUGANDO
    
    private void Start()
    {
        TextoPerder.SetActive(false);                   //DESACTIVA EL TEXTO POR SI ACASO
        BarraTiempo = GetComponent<Image>();            //AGGARA EL SPRITE DEL TIEMPO
        TiempoRestante = TiempoDeJeugo;                 //SE ASIGNA EL TIEMPO

        GameObject otro = GameObject.Find(NombreObjeto);      //ENCUENTRA AL CONTROLADOR
        Controlador = otro.GetComponent<Movimiento>();                            //ENCUENTRA EL SCRIPT DEL CONTROLADOR               
    }
    
    void Update()
    {
            if (TiempoRestante > 0 && Jugando == true)        //LO QUE SUCEDE MIENTRAS AUN HAY TIEMPO
            {
                TiempoRestante -= 1 * Time.deltaTime;
                BarraTiempo.fillAmount = TiempoRestante / TiempoDeJeugo;
            }

            //REMPLASAR LO QUE ESTA DENTRO DEL IF
            if (TiempoRestante > 0 && Jugando == false)                   //LO QUE SUCEDE CUANDO EL JUGADOR GANA
            {
                Jugando = false;
                Ganar();
            }

            if (TiempoRestante <= 0 && Jugando == true)      //LO QUE SUCEDE CUANDO SE ACAVA EL TIEMPO
            {
                Jugando = false;
                Perder();
            }

    }

    public void Perder()                                   //LO QUE SUCEDE CUANDO PIERDES
    {
        Controlador.Jugando = false;                    //TERMINA EL JUEGO
    }

    public void Ganar()                                    //LO QUE SUCEDE CUANDO GANAS
    {
        Debug.Log("ERES UN GANADOR");
        SceneManager.LoadScene("Sc_Ganar");
    }

    public void SiguientePerder()
    {
        SceneManager.LoadScene("Sc_Perder");
    }
}
