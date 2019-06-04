using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSiguienteee : MonoBehaviour
{
    public static int _vida;
    public float timee = 3;
    
    void Update()
    {
        timee -= Time.deltaTime * 1;
        if (timee < 0)
        {
            same();
        }
    }

    void same()
    {
        if (Vida._vida > 0)
        {
            SceneManager.LoadScene("GP_1(No te duermaas)");
        }

        if (Vida._vida == 0)
        {
            SceneManager.LoadScene("Sc_MainMenu");
        }
    }


}

