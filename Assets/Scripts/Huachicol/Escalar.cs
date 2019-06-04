using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Escalar : MonoBehaviour
{
    public GameObject EsteObjeto;
    public bool escalar;
    float Tamaño;

    private void Start()
    {
        Tamaño = EsteObjeto.transform.localScale.x;
        escalar = false;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if( col.tag == "Player")
        {
            //Debug.Log("Choca");
            escalar = true;
        }
    }
    void Update()
    {
        if (escalar == true)
        {
            Tamaño -= Time.deltaTime * 1f;
            EsteObjeto.transform.localScale = new Vector3(Tamaño, Tamaño, Tamaño);
            if (Tamaño <= 0)
            {
                EsteObjeto.SetActive(false);
            }
        }
    }
}
