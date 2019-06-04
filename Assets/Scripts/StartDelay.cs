using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDelay : MonoBehaviour {

    public GameObject Minijuego;            //PONER EL OBJETO QUE CONTROLA EL JUEGO
    public GameObject UI_Tiempo;            //PONER LA BARRA DE TIEMPO
    public float Tiempo = 3f;               //TIEMPO DE DILAY ANTES QUE EMPIESE EL JUEGO
    public GameObject EsperarTxt;

	// Use this for initialization
	void Awake ()
    {
        Minijuego.GetComponent<Movimiento>().enabled = false;             //PONER EL NOMBRE DEL SCRIPT DEL CONTROLADOR DEL JUEGO
        UI_Tiempo.GetComponent<LimiteDeTiempo>().enabled = false;            //PONER EL NOMBRE DEL SCRIPT DEL TIMEPO
        EsperarTxt.SetActive(true);
    }
	
	// Update is called once per frame
	void Update ()
    {
        Tiempo -= 1 * Time.deltaTime;
        if (Tiempo < 0)
        {
            Minijuego.GetComponent<Movimiento>().enabled = true;          //ACTIVA EL JUEGO
            UI_Tiempo.GetComponent<LimiteDeTiempo>().enabled = true;         //ACTIVA EL TIEMPO
            this.enabled = false;                                       //DESACTIVA ESTE SCRIPT
            EsperarTxt.SetActive(false);
        }
        

	}
}
