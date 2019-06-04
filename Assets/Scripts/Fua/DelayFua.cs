using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class DelayFua : MonoBehaviour
{
    public GameObject texto;
    public float tiempo;
    public GameObject jugador;
    public GameObject Tiempo;
    public GameObject Este;

    void Update()
    {
        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime * 1;
        }

        if (tiempo <= 0)
        {
            texto.SetActive(false);
            jugador.SetActive(true);
            Tiempo.GetComponent<LimiteDeTiempoFua>().enabled = true;
            Este.SetActive(false);
        }
    }
}
