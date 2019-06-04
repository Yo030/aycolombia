using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _cocaPlayerScript : MonoBehaviour
{
    private Rigidbody2D Jugador;

    public Text texto;
    
    public float _otroTimer = 3f;

    public bool Jugando;
    public bool DebajoDe;

    // Start is called before the first frame update
    void Start()
    {
        AuidoScript.instance.Play("IntroGameEff");
        AuidoScript.instance.Stop("Marcha");
        Jugador = GetComponent<Rigidbody2D>();
        Jugando = false;
        DebajoDe = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Jugando == true)
        {
            if(DebajoDe == true)
            {
                if (Input.GetMouseButton(0))
                {
                    Ganar();
                }
            }
            
        }

        if (Jugando == false) { _otroTimer -= 1 * Time.deltaTime; }

        if (_otroTimer <= 0)
        {
            texto.text = " ";
            _otroTimer = 5;
            Jugando = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DebajoDe = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        DebajoDe = false;
    }

    public void Perder()
    {
        Jugando = false;
    }
    public void Ganar()
    {
        AuidoScript.instance.Play("Inhala");
        Jugando = false;
        FindObjectOfType<_cocaNarizScript>()._Perder();
        FindObjectOfType<_cocaTimer>().Ganar();
    }
}

