using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TiempoDeEsperaaProxEscena : MonoBehaviour
{
    public float TiempoParaProxEscena;
    public bool Gano = false;
    public bool Perdio = false;


    void Update()
    {
        if(Gano == true)
        {
            PlayerPrefs.SetInt("Colecionable_1", 1);
            AuidoScript.instance.Stop("Ronquido");
            TiempoParaProxEscena -= 1 * Time.deltaTime;
            if (TiempoParaProxEscena <= 0 && Gano == true)
            {
                SceneManager.LoadScene("Sc_Ganar");
            }
        }

        if(Perdio == true)
        {
            AuidoScript.instance.Stop("Ronquido");
            TiempoParaProxEscena -= 1 * Time.deltaTime;
            if (TiempoParaProxEscena <= 0 && Perdio == true)
            {
                SceneManager.LoadScene("Sc_Perder");
            }
        }

    }
}
