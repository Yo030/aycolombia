using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFlash : MonoBehaviour
{

    [Range(0.1f, 5f)]
    public float VelocidadDeFlash;
    private float AlphaMaximo = 1.0f;
    private float AlphaMInimo = 0.0f;
    public float AlphaActual = 0;

    public float R = 255;
    public float G = 255;
    public float B = 255;
    public bool Apagar = false;
    public bool Prender = true;


    void Start()
    {
        
    }

    void Update()
    {
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

        if (Prender == true)
        {
            AlphaActual += VelocidadDeFlash * 0.02f;
            Debug.Log("PRENER");
        }

        if (Apagar == true)
        {
            AlphaActual -= VelocidadDeFlash * 0.01f;
            Debug.Log("APAGER");
        }

        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        this.GetComponent<Text>().color = new Color(R, G, B, AlphaActual);
    }
}
