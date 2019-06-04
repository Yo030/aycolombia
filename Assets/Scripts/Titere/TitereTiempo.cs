using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitereTiempo : MonoBehaviour
{
    Image BarraTiempo;
    public float TiempoDeJeugo = 10;                    //TIEMPO DE JUEGO ES 10 SEGUNDO PREDETERMINADAMENTE
    public float TiempoRestante;                               //TIEMPO QUE QUEDA
    public GameObject perderTxt;
    public TitereColition _titerecolition;

    bool TiempoActivo = true;

    public string NombreDeControlador = " ";                    //NOMBRE DEL OBJETO QUE TIENE EL CONTROLADOR DEL JUEGO
    private MovimientoEscobar _movimintocha;

    void Start()
    {
        BarraTiempo = GetComponent<Image>();            //AGGARA EL SPRITE DEL TIEMPO
        TiempoRestante = TiempoDeJeugo;                 //SE ASIGNA EL TIEMPO

        //GameObject otro = GameObject.Find(NombreDeControlador);     

    }

    void Update()
    {
        TiempoRestante -= 1 * Time.deltaTime;
        BarraTiempo.fillAmount = TiempoRestante / TiempoDeJeugo;
        if (TiempoRestante <= 0)
        {
            perderTxt.SetActive(true);
            _titerecolition.enabled = false;
        }
    }
}
