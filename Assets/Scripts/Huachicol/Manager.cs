using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public bool Jugando;

    private void Start()
    {
        AuidoScript.instance.Play("IntroGameEff");
        AuidoScript.instance.Play("FugaEff");
        AuidoScript.instance.Set_Volume("Marcha", 0.25f);
        Jugando = true;
    }
    // Update is called once per frame
    private void Update()
    {
        if (Jugando == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                FindObjectOfType<Player_Manager>().onMouseClick();
            }
        }
    }

    public void Perder()
    {
        Jugando = false;
    }
}
