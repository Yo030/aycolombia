using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSiguiente : MonoBehaviour
{

    public float timee = 3;

    // Update is called once per frame
    void Update()
    {
        timee -= Time.deltaTime * 1;
        if (timee < 0)
        {
            SceneManager.LoadScene("Sc_StartMenu");
        }
        
    }
}
