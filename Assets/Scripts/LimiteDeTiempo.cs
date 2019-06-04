using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LimiteDeTiempo : MonoBehaviour
{
    Image BarraTiempo;
    public float TiempoDeJeugo = 10;                    //TIEMPO DE JUEGO ES 10 SEGUNDO PREDETERMINADAMENTE
    public float TiempoRestante;                               //TIEMPO QUE QUEDA
    bool TiempoActivo = true;

    public string NombreDeControlador = " ";                    //NOMBRE DEL OBJETO QUE TIENE EL CONTROLADOR DEL JUEGO

    Movimiento ControladorMovimiento;

    // Start is called before the first frame update
    void Awake()
    {
        BarraTiempo = GetComponent<Image>();            //AGGARA EL SPRITE DEL TIEMPO
		TiempoDeJeugo = TiempoDeJeugo+Vida.ResterTiempo;
        TiempoRestante = TiempoDeJeugo;                 //SE ASIGNA EL TIEMPO

        GameObject otro = GameObject.Find(NombreDeControlador);      //ENCUENTRA AL CONTROLADOR
        ControladorMovimiento = otro.GetComponent<Movimiento>();                            //ENCUENTRA EL SCRIPT DEL CONTROLADOR               
    }

    // Update is called once per frame
    void Update()
    {
        if (TiempoActivo == true)
        {
            if (TiempoRestante > 0 && ControladorMovimiento.Jugando == true)        //LO QUE SUCEDE MIENTRAS AUN HAY TIEMPO
            {
                TiempoRestante -= 1 * Time.deltaTime;
                BarraTiempo.fillAmount = TiempoRestante / TiempoDeJeugo;
            }

            if (TiempoRestante > 0 && ControladorMovimiento.Jugando == false )                   //LO QUE SUCEDE CUANDO EL JUGADOR GANA
            {
                if(ControladorMovimiento.Perdio == true)
                {
                    ControladorMovimiento.Jugando = false;
                    //ControladorMovimiento.Ganar();
                    TiempoActivo = false;
                }

                else
                {
                    ControladorMovimiento.Jugando = false;
                    ControladorMovimiento.Ganar();
                    TiempoActivo = false;
                }
                
            }

            if (TiempoRestante <= 0 && ControladorMovimiento.Jugando == true)      //LO QUE SUCEDE CUANDO SE ACAVA EL TIEMPO
            {
                ControladorMovimiento.Jugando = false;
                ControladorMovimiento.Ganar();
                TiempoActivo = false;
            }
        }
    }
}
