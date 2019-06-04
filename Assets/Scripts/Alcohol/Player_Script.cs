using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Script : MonoBehaviour
{
    private Rigidbody2D Jugador;

    public Text texto;
    //public AudioSource alcoholEffect; //aldooo
    float X;
    public float timer = 3f;
    public float _otroTimer = 3f;
    public float velocityX;

    public bool jugando;
    public bool llenando;
    public bool estado;
    public bool estado2;
    public bool estado3;
    public bool estado4;
    public bool estado5;
    
    
    public KeyCode _left;
    public KeyCode _right;
    public float _test_velocity;

    public bool reto;

    private Animator anim;

    private void Start()
    {
        Jugador = GetComponent<Rigidbody2D>();
        reto = true;
        anim = GetComponent<Animator>();
        AuidoScript.instance.Force_Play("AlcoholEff");
        AuidoScript.instance.Play("IntroGameEff");
        AuidoScript.instance.Set_Volume("Marcha", 0.25f);
        jugando = false;
        llenando = false;
        estado = true;
        estado2 = false;
        estado3 = false;
        estado4 = false;
        estado5 = false;
    }

    public void onLoose()
    {
        jugando = false;
    }

    void Victoria()
    {
        if(reto == true)
        {
            PlayerPrefs.SetInt("Colecionable_3", 1);
        }
        AuidoScript.instance.Mute("AlcoholEff");
        texto.text = ("Ganaste!");
        FindObjectOfType<Botella_Script>()._Perder();
        FindObjectOfType<_timerAlcohol>().Ganar();
        StartCoroutine(_waitASec());
    }

    public void onColitionTrue()
    {
        llenando = true;
        AuidoScript.instance.Play("AlcoholEff");
        //alcoholEffect.Play();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        switch (Jugador.collisionDetectionMode)
        {
            case CollisionDetectionMode2D.Continuous:
                Debug.Log("A");
                Jugador.collisionDetectionMode = CollisionDetectionMode2D.Discrete;
                break;
            case CollisionDetectionMode2D.Discrete:
                Debug.Log("B");
                Jugador.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
                break;

        }
    }
    public void onColitionFalse()
    {
        reto = false;
        llenando = false;
        AuidoScript.instance.Stop("AlcoholEff");
        //alcoholEffect.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (jugando)
        {
            X = Input.acceleration.x * (Time.deltaTime * -velocityX);
            if (X >= 12)
            {
                X = 12;
            }
            transform.Translate(-X, 0, 0);

            if ( timer > 0 && llenando)
            {
                timer -= 1 * Time.deltaTime;
            }
            if (timer <= 0 && estado)
            {
                estado2 = true;
                estado = false;
                timer = 1.2f;
            }
            else if (timer <= 0 && estado2)
            {
                estado3 = true;
                estado2 = false;
                timer = 1.4f;
            }
            else if (timer <= 0 && estado3)
            {
                estado4 = true;
                estado3 = false;
                timer = 1.6f;
            }
            else if (timer <= 0 && estado4)
            {
                estado5 = true;
                estado4 = false;
                timer = 1.8f;
            }
            if (estado5)
            {
                Victoria();
            }

            
            if (_test_velocity >= 12)
            {
                _test_velocity = 12;
            }
            if (Input.GetKey(_left))
            {
                Jugador.velocity = new Vector2(-_test_velocity, 0);
            }
            else if (Input.GetKey(_right))
            {
                Jugador.velocity = new Vector2(_test_velocity, 0);
            }
        }

        if(jugando == false) { _otroTimer -= 1 * Time.deltaTime; }

        if(_otroTimer <= 0)
        {
            texto.text = " ";
            _otroTimer = 5; 
            jugando = true;
        }

        
        

        anim.SetBool("Estado 2", estado2);
        anim.SetBool("Estado 3", estado3);
        anim.SetBool("Estado 4", estado4);
        anim.SetBool("Estado 5", estado5);

    }

    public void _Perder()
    {
        jugando = false;
    }

    IEnumerator _waitASec()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Sc_Ganar");
    }
}
