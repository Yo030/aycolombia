using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayTitere : MonoBehaviour
{
    public GameObject texto;
    public float tiempo;
    public GameObject varGameObject;
    public GameObject jugador;
    public GameObject Tiempo;
    public GameObject Titere;
    public GameObject Este;

    void Update()
    {
        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime * 1;
        }

        if (tiempo <= 0)
        {
            texto.SetActive(false); varGameObject.SetActive(true);
            Tiempo.GetComponent<TitereTiempo>().enabled = true;
            Este.SetActive(false);
        }
    }
}
