using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ajitar : MonoBehaviour
{
    public float Sensibilidad = 2f;
    public float TiempoParaDetectarProxShake =0.1f;
    public float VelocidadDeLlenar;
    private float sqrSensibilidad;
    private float timeSinceLastShake;
    public float CantidadDeLlenado = 0;
    public float TopeDeLlenado = 10;
    public Image BarraFua;
    bool jugando = true;
    public float TiempoParaProximaEscena = 2.5f;
    public GameObject Tiempo;
    public GameObject GanasteTxt;
    private Image EstaImagen;
    public Sprite F1;
    public Sprite F2;
    public Sprite F3;
    public Sprite F4;


    void Awake()
    {
        TopeDeLlenado = TopeDeLlenado + (Vida.ResterTiempo * 2);                 //SE ASIGNA EL TIEMPO
        //TopeDeLlenado = CantidadDeLlenado;
    }
    
    void Start()
    {
        BarraFua = GetComponent<Image>();            //AGGARA EL SPRITE DEL TIEMPO
        sqrSensibilidad = Mathf.Pow(Sensibilidad, 2);
        EstaImagen = GetComponent<Image>();
    }

    void Update()
    {
        if (Input.deviceOrientation == DeviceOrientation.FaceUp)
        {
            if (Input.acceleration.sqrMagnitude >= sqrSensibilidad && Time.unscaledTime >= timeSinceLastShake + TiempoParaDetectarProxShake && jugando == true)
            {
                CantidadDeLlenado += VelocidadDeLlenar;
                BarraFua.fillAmount = CantidadDeLlenado / TopeDeLlenado;
                timeSinceLastShake = Time.unscaledTime;
            }
            
        }
        
        if (CantidadDeLlenado <= 5)
        {
            EstaImagen.sprite = F1;
        }
        if (CantidadDeLlenado > 5 && CantidadDeLlenado  <= 10)
        {
            EstaImagen.sprite = F2;
        }
        if (CantidadDeLlenado > 10 && CantidadDeLlenado <= 15)
        {
            EstaImagen.sprite = F3;
        }
        if (CantidadDeLlenado > 15 && CantidadDeLlenado <= 20)
        {
            EstaImagen.sprite = F4;
        }


        if (CantidadDeLlenado >= TopeDeLlenado)
        {
            jugando = false;
            TiempoParaProximaEscena -= Time.deltaTime * 1;
            Tiempo.GetComponent<LimiteDeTiempoFua>().enabled = false;
            GanasteTxt.SetActive(true);
        }

        if (TiempoParaProximaEscena <= 0)
        {
            SceneManager.LoadScene("Sc_Ganar");
        }
    }



}

