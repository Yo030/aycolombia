using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasillaMORENAController : MonoBehaviour
{
    public GameObject controller;
    void OnCollisionEnter2D(Collision2D coll)
    {
        CanvasController_Votaciones Controller = controller.GetComponent<CanvasController_Votaciones>();
        if (coll.collider.name == "Monito_MORENA")
        {
            AuidoScript.instance.Play("Correcto");
            Debug.Log("PAN");
            Destroy(coll.gameObject);
            Controller.monitos++;
        }
        else
        {
            AuidoScript.instance.Play("Incorrecto");
            Destroy(coll.gameObject);
            Debug.Log("Perdiste");
            Controller.Perdiste();
        }
    }
}
