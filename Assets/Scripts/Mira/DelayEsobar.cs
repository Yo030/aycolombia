using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayEsobar : MonoBehaviour
{
    public GameObject texto;
    public float tiempo;
    public GameObject varGameObject;
    public GameObject jugador;
    public GameObject Tiempo;
    public GameObject Escobar;
    public GameObject Este;
    public Animator AnimadorDeJugador;

    void Update()
    {
        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime * 1;
        }

        if (tiempo <= 0)
        {
            texto.SetActive(false); varGameObject.SetActive(true);
            jugador.GetComponent<DragScript>().enabled = true;
            Tiempo.GetComponent<TiempoEscobar>().enabled = true;
            Escobar.GetComponent<MovimientoEscobar>().enabled = true;
            Este.SetActive(false);
            AnimadorDeJugador.enabled = true;
        }
    }
}
