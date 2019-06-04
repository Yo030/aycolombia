using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PerdioFinal : MonoBehaviour
{
    public Text _Puntos;

    void Start()
    {
        _Puntos.text = Vida.Puntuaje.ToString();
        if (Vida.Puntuaje == 50)
        {
            PlayerPrefs.SetInt("Colecionable_6", 1);
        }
    }
}
