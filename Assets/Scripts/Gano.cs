using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gano : MonoBehaviour
{
    public Text Puntos;
    public Text Aguanta;
    public float TiempoDeEspera_Aguantale = 5;
    public float TiempoDeEspera_Ya = 5;

    public float R = 0;
    public float G = 0;
    public float B = 0;
    [Range(0.1f, 5f)]
    public float VelocidadDeFlash;
    public GameObject Caguama1;
    public GameObject Caguama2;
    private float AlphaMaximo = 1.0f;
    private float AlphaMInimo = 0.0f;
    public float AlphaActual = 0;
    private bool Flash = true;
    private bool Prender = true;
    private bool Apagar = false;
    private PorximaEscena ProximoJuego = new PorximaEscena();


    void Awake()
    {
        switch (Vida._vida)
        {
            case 3:
                Caguama1.SetActive(true);
                Caguama2.SetActive(true);
                break;

            case 2:
                Caguama1.SetActive(false);
                Caguama2.SetActive(true);
                break;
            case 1:
                Caguama1.SetActive(false);
                Caguama2.SetActive(false);
                break;
        }
    }


    void Start()
    {
        Vida.Puntuaje += 1;
        Vida.CuentaDeNiveles += 1;
        Puntos.text = Vida.Puntuaje.ToString();
        Debug.Log(Vida.CuentaDeNiveles);
        switch (Vida.CuentaDeNiveles)
        {
            case 3:
                Vida.ResterTiempo = 2;
                Debug.Log("MENOS 2 SEG");
                break;

            case 6:
                Vida.ResterTiempo = 4;
                Debug.Log("MENOS 4 SEG");
                break;

            case 9:
                Vida.ResterTiempo = 6;
                Debug.Log("MENOS 6 SEG");
                break;
        }

    }

    void Update()
    {
        TiempoDeEspera_Aguantale -= Time.deltaTime * 1;

        if (TiempoDeEspera_Aguantale <= 0)
        {
            Flash = false;
            TiempoDeEspera_Ya -= Time.deltaTime * 1;
            AlphaActual += VelocidadDeFlash * 0.03f;
            Aguanta.text = "¡Ya!";
        }

        if (TiempoDeEspera_Ya <= 0)
        {
            ProximoJuego.NextScean();
        }

        //

        if (Prender == true && Flash == true)
        {
            AlphaActual += VelocidadDeFlash * 0.02f;
        }

        if (Apagar == true && Flash == true)
        {
            AlphaActual -= VelocidadDeFlash * 0.01f;
        }

        if (AlphaActual >= 1)
        {
            Prender = false;
            Apagar = true;
        }
        if (AlphaActual <= 0)
        {
            Prender = true;
            Apagar = false;
        }
        //
    }
    
    void FixedUpdate()
    {
        this.GetComponent<Text>().color = new Color(R, G, B, AlphaActual);
    }
}