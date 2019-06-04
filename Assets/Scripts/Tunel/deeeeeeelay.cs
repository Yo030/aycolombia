using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class deeeeeeelay : MonoBehaviour
{
    public GameObject texto;
    public float tiempo;
    public GameObject varGameObject;
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
            texto.SetActive(false);varGameObject.SetActive(true);
            jugador.GetComponent<Movimintocha>().enabled = true;
            Tiempo.GetComponent<Tiemo>().enabled = true;
            Este.SetActive(false);
        }
    }
}
