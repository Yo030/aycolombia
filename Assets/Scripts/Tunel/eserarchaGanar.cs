using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class eserarchaGanar: MonoBehaviour
{
    private float timeo = 2.5f;

    // Update is called once per frame
    void Update()
    {
        timeo -= Time.deltaTime * 1;

        if (timeo <= 0)
        {
            SceneManager.LoadScene("Sc_Ganar");
        }
    }
}
