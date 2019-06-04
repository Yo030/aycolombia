using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _lost_manager : MonoBehaviour
{
    public Image _presidente1;
    public Image _presidente2;
    public Image _presidente3;
    public Image _presidente4;
    public Image _presidente5;

    public Text _texto;

    public float _otroTimer = 3f;

    public int random;

    public bool Jugando;

    void Start()
    {
        AuidoScript.instance.Play("IntroGameEff");
        AuidoScript.instance.Stop("Marcha");
        AuidoScript.instance.Play("Grillos");
        _presidente1.enabled = false;
        _presidente2.enabled = false;
        _presidente3.enabled = false;
        _presidente4.enabled = false;
        _presidente5.enabled = false;
        
    }

    void Update()
    {
        if (Jugando == false) { _otroTimer -= 1 * Time.deltaTime; }

        if (_otroTimer <= 0)
        {
            _presidenteRandom();
            _texto.text = " ";
            _otroTimer = 5;
            Jugando = true;
        }
    }

    void _presidenteRandom()
    {
        random = Random.Range(1, 5);
        switch (random)
        {
            case 1:
                _presidente1.enabled = true;
                break;
            case 2:
                _presidente2.enabled = true;
                break;
            case 3:
                _presidente3.enabled = true;
                break;
            case 4:
                _presidente4.enabled = true;
                break;
            case 5:
                _presidente5.enabled = true;
                break;
        }
    }

    public void _clickEnPresidente()
    {
        AuidoScript.instance.Play("Auch");
        _presidente1.enabled = false;
        _presidente2.enabled = false;
        _presidente3.enabled = false;
        _presidente4.enabled = false;
        _presidente5.enabled = false;
        ganar();
    }

    public void perder()
    {
        Jugando = false;
        
    }
    public void ganar()
    {
        AuidoScript.instance.Stop("Grillos");
        Jugando = false;
        FindObjectOfType<_timer_Lost>().Ganar();
    }
}
