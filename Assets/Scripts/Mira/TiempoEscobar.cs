using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiempoEscobar : MonoBehaviour
{
    Image BarraTiempo;
    public float TiempoDeJeugo = 10;                    //TIEMPO DE JUEGO ES 10 SEGUNDO PREDETERMINADAMENTE
    public float TiempoRestante;                               //TIEMPO QUE QUEDA
    public GameObject perderTxt;
    public MovimientoEscobar _movimintoescobar;
    public GameObject Walls;


    bool TiempoActivo = true;

    public string NombreDeControlador = " ";                    //NOMBRE DEL OBJETO QUE TIENE EL CONTROLADOR DEL JUEGO
    private MovimientoEscobar _movimintocha;
    //Movimintocha ControladorMovimiento;

    // Start is called before the first frame update
    void Start()
    {
        BarraTiempo = GetComponent<Image>();            //AGGARA EL SPRITE DEL TIEMPO
        TiempoRestante = TiempoDeJeugo;                 //SE ASIGNA EL TIEMPO

        GameObject otro = GameObject.Find(NombreDeControlador);      //ENCUENTRA AL CONTROLADOR  
        //_movimintocha = otro.GetComponent<MovimientoEscobar>();
    }

    void Update()
    {
        TiempoRestante -= 1 * Time.deltaTime;
        BarraTiempo.fillAmount = TiempoRestante / TiempoDeJeugo;
        if (TiempoRestante <= 0)
        {
            perderTxt.SetActive(true);
            _movimintoescobar.enabled = false;
            Walls.SetActive(false);
        }
    }
}
