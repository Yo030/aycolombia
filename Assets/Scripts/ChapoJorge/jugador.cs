using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class jugador : MonoBehaviour
{
    public GameObject Obstaculos;
    public GameObject Tiempo;
    public GameObject Intro;

    public float velocidad_de_rotacion = 600f;

    float movimiento = 0f;

    public static bool RetoCollec;

    // Update is called once per frame
    private void Start()
    {
        RetoCollec = true;

        Invoke("empizaaaa", 2);
        Invoke("empizaaaa2", 4);
        AuidoScript.instance.Play("PasosEff");
        AuidoScript.instance.Play("IntroGameEff");
        AuidoScript.instance.Set_Volume("Marcha", 0.25f);
    }
    void Update()
    {
  
        // movimiento = Input.GetAxisRaw("Horizontal");
        //Debug.Log(movimiento);
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movimiento * Time.fixedDeltaTime * -velocidad_de_rotacion);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AuidoScript.instance.Stop("PasosEff");
        //Debug.Log("Sc_MainMenu");
        SceneManager.LoadScene("Sc_Perder");
    }


    public void movIzq()
    {
        RetoCollec = false;
        movimiento = -1;
    }

    public void movDer()
    {
        movimiento = 1;
    }

    public void onRelease()
    {
        movimiento = 0;
    }

    void empizaaaa()
    {
        Intro.SetActive(!Intro.activeSelf);
       
    }

    void empizaaaa2()
    {
        Obstaculos.SetActive(!Obstaculos.activeSelf);
        Tiempo.SetActive(!Tiempo.activeSelf);
    }
}
