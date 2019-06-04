using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _bronxManager : MonoBehaviour
{
    public Text _texto;

    public float _otroTimer = 3f;

    public bool Jugando;

    // Start is called before the first frame update
    void Start()
    {
        AuidoScript.instance.Play("IntroGameEff");
        AuidoScript.instance.Stop("Marcha");
    }

    // Update is called once per frame
    void Update()
    {
        if (Jugando == false) { _otroTimer -= 1 * Time.deltaTime; }

        if (_otroTimer <= 0)
        {
            _texto.text = " ";
            _otroTimer = 5;
            Jugando = true;
        }
    }
}
