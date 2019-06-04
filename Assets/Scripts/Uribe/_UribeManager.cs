using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _UribeManager : MonoBehaviour
{
    public Text _texto;

    public float _otroTimer = 3f;

    public bool Jugando;

    public int Counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        AuidoScript.instance.Play("IntroGameEff");
        AuidoScript.instance.Stop("Marcha");
        AuidoScript.instance.Play("UribeMosco");
    }

    // Update is called once per frame
    void Update()
    {
        if(Counter >= 4)
        {
            FindObjectOfType<_UribeTimer>().Ganar();
        }

        if (Jugando == false) { _otroTimer -= 1 * Time.deltaTime; }

        if (_otroTimer <= 0)
        {
            _texto.text = " ";
            _otroTimer = 5;
            Jugando = true;
        }
    }

    public void CounterPlusPlus()
    {
        if (Jugando == true) { Counter++; }
    }
}
