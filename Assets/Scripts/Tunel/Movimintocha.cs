using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movimintocha : MonoBehaviour
{
    private bool Click = false;

    private Rigidbody2D _botella;

    public float _velocity;
    public bool _izquierda;
    public bool _jugando = true;

    public bool Perdio = false;
    public bool Ganar = false;


    public GameObject Coliders;
    public GameObject WinTxt;
    public GameObject LooseTxt;

    public GameObject Tiempo;


    private bool Moviendose = true;
    private bool moverArriba;
    private bool PararMoverArriba;

    // Start is called before the first frame update
    void Start()
    {
        _botella = GetComponent<Rigidbody2D>();
        _izquierda = true;
        //_jugando = true;
        _botella.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (_jugando == true && Moviendose==true)
        {
            if (_izquierda)
            {
                _botella.velocity = new Vector2(-_velocity, 0);
            }
            else
            {
                _botella.velocity = new Vector2(_velocity, 0);
            }
        }

        if (_jugando == true && moverArriba == true)
        {
                _botella.velocity = new Vector2(0, _velocity);
        }

        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Click");
            Click = true;
        }

        else
        {
            Click = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            if (_izquierda)
            {
                _izquierda = false;
            }
            else
            {
                _izquierda = true;
            }
        }

        if (other.tag == "No" && Click == true)
        {
            Moviendose = false;
        }

        if (other.name == "Stop")
        {
            _botella.velocity = new Vector2(0, 0);
            moverArriba = false;
            Coliders.SetActive(true);
        }

        if (other.tag == "Loose")
        {
            LooseTxt.SetActive(true);
        }

        if (other.tag == "Win")
        {
            WinTxt.SetActive(true);
        }

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Click == true)
        {
            if (other.tag == "No" || other.tag == "Si")
            {
                Tiempo.GetComponent<Tiemo>().enabled = false;
                Moviendose = false;
                _botella.velocity = new Vector2(0, 0);
                moverArriba = true;
            }
        }

    }



}
