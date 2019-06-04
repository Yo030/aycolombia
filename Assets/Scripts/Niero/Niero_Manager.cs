using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Niero_Manager : MonoBehaviour
{
    private Rigidbody2D Jugador;

    public float velocity; //Velocidad con la que avanza.
    public float _otroTimer = 3f;

    public bool Jugando; //Checa si juega o no.

    
    // Start is called before the first frame update
    void Start()
    {
        AuidoScript.instance.Play("IntroGameEff");
        AuidoScript.instance.Stop("Marcha");
        
        Jugador = GetComponent<Rigidbody2D>();
        Jugador.gravityScale = 0;
        Jugando = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Jugando == true)
        {
            Jugador.velocity = new Vector2(0.5f, 0);

            if (Input.GetMouseButtonDown(0))
            {
                onMouseClick();
            }
        }
        if (Jugando == false) { _otroTimer -= 1 * Time.deltaTime; }

        if (_otroTimer <= 0)
        {
            AuidoScript.instance.Play("Blablabla");
            _otroTimer = 5;
            Jugando = true;
        }
    }

    public void onLoose()
    {
        Jugando = false;
    }

    public void onMouseClick()
    {
        if (Jugando == true)
        {
            Jugador.velocity = new Vector2(-velocity, 0);
            StartCoroutine(tapTime());
        }
    }

    IEnumerator tapTime()
    {
        yield return new WaitForSeconds(0.01f);
        //Debug.Log(counter);
        Jugador.velocity = new Vector2(0, 0);
    }
}
