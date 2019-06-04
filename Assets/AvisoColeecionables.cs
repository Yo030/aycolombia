using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AvisoColeecionables : MonoBehaviour
{
    public GameObject panelColeccionable;
    public float time;


    void Start()
    {
        mostrarpanel();
    }

    void mostrarpanel()
    {
        //PlayerPrefs.SetInt("Colecionable_1", 1);              //TEST DE CUANDO YA SE DESBLOQUEA CUALQUIER COLECCIONABLE
       // PlayerPrefs.SetInt("Colecionable_2", 1);
        if (PlayerPrefs.GetInt("Colecionable_1") == 1 && PlayerPrefs.GetInt("Colecionable_1_BOOL") == 0)
        {
            panelColeccionable.SetActive(!panelColeccionable.activeSelf);

            PlayerPrefs.SetInt("Colecionable_1_BOOL", 1);

            Invoke("quitarAnuncio", time); 
        }
        if (PlayerPrefs.GetInt("Colecionable_2") == 1 && PlayerPrefs.GetInt("Colecionable_2_BOOL") == 0)
        {
            panelColeccionable.SetActive(!panelColeccionable.activeSelf);

            PlayerPrefs.SetInt("Colecionable_2_BOOL", 1);

            Invoke("quitarAnuncio", time);

        }
        if(PlayerPrefs.GetInt("Colecionable_3") == 1 && PlayerPrefs.GetInt("Colecionable_3_BOOL") == 0)
        {
            panelColeccionable.SetActive(!panelColeccionable.activeSelf);

            PlayerPrefs.SetInt("Colecionable_3_BOOL", 1);

            Invoke("quitarAnuncio", time);
        }
        if(PlayerPrefs.GetInt("Colecionable_4") == 1 && PlayerPrefs.GetInt("Colecionable_4_BOOL") == 0)
        {
            panelColeccionable.SetActive(!panelColeccionable.activeSelf);

            PlayerPrefs.SetInt("Colecionable_4_BOOL", 1);

            Invoke("quitarAnuncio", time);
        }
        if(PlayerPrefs.GetInt("Colecionable_5") == 1 && PlayerPrefs.GetInt("Colecionable_5_BOOL") == 0)
        {
            panelColeccionable.SetActive(!panelColeccionable.activeSelf);

            PlayerPrefs.SetInt("Colecionable_5_BOOL", 1);

            Invoke("quitarAnuncio", time);
        }
        if(PlayerPrefs.GetInt("Colecionable_6") == 1 && PlayerPrefs.GetInt("Colecionable_6_BOOL") == 0)
        {
            panelColeccionable.SetActive(!panelColeccionable.activeSelf);

            PlayerPrefs.SetInt("Colecionable_6_BOOL", 1);

            Invoke("quitarAnuncio", time);
        }
    }

    void quitarAnuncio()
    {
        Debug.Log("ENTRANDO");
        panelColeccionable.SetActive(!panelColeccionable.activeSelf);
    }

}
