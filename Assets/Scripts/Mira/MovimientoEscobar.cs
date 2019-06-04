using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering;

public class MovimientoEscobar : MonoBehaviour
{
    public float _velocity;
    public bool _jugando = true;
    public bool _izquierda;
    private bool Moviendose = true;
    public bool Fire;
    public int Ballas = 3;
    public bool ColitionCheck;
    public float FireTimer;
    public GameObject Tiempo;
    public GameObject Hoyo;
    public GameObject Mira;
    public Animator ThisAnimator;
    public SpriteRenderer ThisSprite;
    public Sprite SpriteMuerto;

    public bool Muerto;
    public GameObject GanoTxt;
    public GameObject PerdioTxt;
    public GameObject Walls;

    private Rigidbody2D Personaje;
    private Vector3 VoltearDerecha;
    private Vector3 VolteaIzquierda;

    // Start is called before the first frame update
    void Start()
    {
        ThisSprite = GetComponent<SpriteRenderer>();
        _izquierda = true;
        Personaje = GetComponent<Rigidbody2D>();
        VoltearDerecha = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        VolteaIzquierda = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (_jugando == true && Moviendose == true)
        {
            if (_izquierda)
            {
                Personaje.velocity = new Vector2(-_velocity, 0) * Time.deltaTime;
                VoltiarIzq();
            }
            else
            {
                Personaje.velocity = new Vector2(_velocity, 0) * Time.deltaTime;
                VoltiarDer();
            }
        }

        if (FireTimer >= 0)
        {
        FireTimer -= 1*Time.deltaTime;
        }
        if (FireTimer <= 0)
        {
            Fire = false;
        }

        if (Fire && ColitionCheck)
        {
            Tiempo.SetActive(false);
            Debug.Log("MUERTO!");
            Muerto = true;
        }

        if (Muerto)
        {
            Personaje.velocity = new Vector2(0, 0) * Time.deltaTime;
            this.gameObject.transform.localScale = new Vector3(0.804188f, 0.804188f, 1);
            ThisAnimator.enabled = false;
            ThisSprite.sprite = SpriteMuerto; 
            _jugando = false;
            Gano();
        }

        if (Ballas <= 0 && Muerto == false)
        {
            _jugando = false;
            Perdio();
        }
        Mouse();
    }

    public void Gano()
    {
        PlayerPrefs.SetInt("Colecionable_4", 1);
        GanoTxt.SetActive(true);
    }

    public void Perdio()
    {
        Tiempo.SetActive(false);
        _jugando = false;
        Walls.SetActive(false);
        PerdioTxt.SetActive(true);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Wall")
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
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Mira2D")
        {
            Debug.Log("EN LA MIRA");
            ColitionCheck = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Mira2D")
        {
            Debug.Log("EN LA MIRA");
            ColitionCheck = false;
        }
    }

    void Mouse()
    {
        if (Input.GetMouseButtonUp(0) && Ballas >= 1)
        {

            AuidoScript.instance.Play("Disparo");
            Fire = true;
            Ballas--;
            Debug.Log("DISPARO!");
            Instantiate(Hoyo, new Vector3(Mira.transform.position.x, Mira.transform.position.y, 3), Quaternion.identity);
            FireTimer = .1f;
        }
    }

    void VoltiarDer()
    {
        transform.localScale = VoltearDerecha;
    }

    void VoltiarIzq()
    {
        transform.localScale = VolteaIzquierda;
    }

}