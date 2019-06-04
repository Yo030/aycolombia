using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders_GP3 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Botella")
        {
            FindObjectOfType<_cocaNarizScript>().onCollide();
        }/*
        if(col.tag == "Player")
        {
            FindObjectOfType<Player_Script>().onColitionTrue();
        }*/
    }
    public void OnTriggerExit2D(Collider2D col)
    {/*
        if (col.tag == "Player")
        {
            FindObjectOfType<Player_Script>().onColitionFalse();
        }*/
    }
    
}
