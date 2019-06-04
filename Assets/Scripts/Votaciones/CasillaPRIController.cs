using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasillaPRIController : MonoBehaviour
{
    public GameObject controller;


    void OnCollisionEnter2D(Collision2D coll)
    {
        CanvasController_Votaciones Controller = controller.GetComponent<CanvasController_Votaciones>();

        if (coll.collider.name == "Monito_PRI")
        {
            Debug.Log("PAN");
            AuidoScript.instance.Play("Correcto");
            Destroy(coll.gameObject);
            Controller.monitos++;
        }
        else 
        {
            AuidoScript.instance.Play("Incorrecto");
            Debug.Log("Perdiste");
            Destroy(coll.gameObject);
            Controller.Perdiste();
        }
    }
}
