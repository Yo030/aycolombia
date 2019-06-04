using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiemo : MonoBehaviour
{
    Image BarraTiempo;
    public float TiempoDeJeugo = 10;                    //TIEMPO DE JUEGO ES 10 SEGUNDO PREDETERMINADAMENTE
    public float TiempoRestante;                               //TIEMPO QUE QUEDA


    public GameObject ActivarMovimiento;
    bool TiempoActivo = true;

    public string NombreDeControlador = " ";                    //NOMBRE DEL OBJETO QUE TIENE EL CONTROLADOR DEL JUEGO


    //Movimintocha ControladorMovimiento;

    // Start is called before the first frame update
    void Start()
    {
        BarraTiempo = GetComponent<Image>();            //AGGARA EL SPRITE DEL TIEMPO
        TiempoRestante = TiempoDeJeugo;                 //SE ASIGNA EL TIEMPO

        GameObject otro = GameObject.Find(NombreDeControlador);      //ENCUENTRA AL CONTROLADOR    
    }

    void Update()
    {
                    TiempoRestante -= 1 * Time.deltaTime;
                    BarraTiempo.fillAmount = TiempoRestante / TiempoDeJeugo;
                
    }
}
