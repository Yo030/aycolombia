using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Manager : MonoBehaviour
{
    private Rigidbody2D Tapon;
    public float velocity; //Velocidad con la que avanza.

    public bool Jugando; //Checa si juega o no.

    public float _otroTimer = 3f;

    

    // Use this for initialization
    private void Start()
    {
        Tapon = GetComponent<Rigidbody2D>();
        Tapon.gravityScale = 0;
        Jugando = false;

    }

    private void Update()
    {
        if (Jugando)
        {
            Tapon.velocity = new Vector2(0, 0.5f);
        }
        if (Jugando == false) { _otroTimer -= 1 * Time.deltaTime; }

        if (_otroTimer <= 0)
        {
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
        if (Jugando)
        {
            Tapon.velocity = new Vector2(0, -velocity);
            StartCoroutine(tapTime());
        }
    }

    IEnumerator tapTime()
    {
        yield return new WaitForSeconds(0.01f);
        //Debug.Log(counter);
        Tapon.velocity = new Vector2(0, 0);
    }
}
