using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasillaPANController : MonoBehaviour
{
    public GameObject controller;
    public Animator Animador;
    public float TiempoDeAnimacion;
    private float AnimationTime;
    public SpriteRenderer SpRenderer;
    public Sprite SpriteBolsa0;

    void Start()
    {
        AnimationTime = TiempoDeAnimacion;
        SpRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (TiempoDeAnimacion >0)
        {
            TiempoDeAnimacion -= Time.deltaTime * 1;
        }
            if (Animador.enabled == true && TiempoDeAnimacion < 0)
            {
                Animador.enabled = false;
                SpRenderer.sprite = SpriteBolsa0;
            }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        CanvasController_Votaciones Controller = controller.GetComponent<CanvasController_Votaciones>();
        if (coll.collider.tag == "Gema")
        {
            AuidoScript.instance.Play("Correcto");
            Debug.Log("PAN");
            Destroy(coll.gameObject);
            Controller.monitos+= 1;
            TiempoDeAnimacion = AnimationTime;
            Animador.enabled = true;
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
