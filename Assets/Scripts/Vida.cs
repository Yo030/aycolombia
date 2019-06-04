using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    public static int _vida = 3;
    public static int Puntuaje = 0;
	public static int CuentaDeNiveles = 0;
	public static int ResterTiempo = 0;

    public static int OpcionDesarrollador = 1;
    private void Start()
    {
        _vida = 3;
        CuentaDeNiveles = 0;
        ResterTiempo = 0;
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Sc_StartMenu")
        {
            _vida = 1;
            Puntuaje = 0;
            Debug.Log("Vida = " + _vida);
        }
        Puntuaje = 0;
    }

    public void NextScean()
    {
        if (_vida <= 0)
        {
            SceneManager.LoadScene("Sc_MainMenu");
        }
        else if (_vida > 0)
        {
            SceneManager.LoadScene("GP_1(No te duermaas)");
        }
        
    }
}
