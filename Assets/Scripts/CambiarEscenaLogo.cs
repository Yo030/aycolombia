using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaLogo : MonoBehaviour
{
    public float TiempoParaProxEscena;

    void Update()
    {
            TiempoParaProxEscena -= Time.deltaTime * 1;

        if (TiempoParaProxEscena < 0)
        {
            TiempoAcavado();
        }
    }

    void TiempoAcavado()
    {
        SceneManager.LoadScene("Sc_StartMenu");
    }
    
}

