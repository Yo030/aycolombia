using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _mascaraManager : MonoBehaviour
{
    public Image _mascara;
    public Image _cerdo;

    public Text _texto;

    Color _mascaraColor;

    public bool Jugando;

    public float _otroTimer;
    public float _alphacolor;
    public float _alphacolor2;

    // Start is called before the first frame update
    void Start()
    {
        AuidoScript.instance.Play("IntroGameEff");
        AuidoScript.instance.Stop("Marcha");

        _mascara.color = new Color(1, 1, 1, _alphacolor);
        _cerdo.color = new Color(1, 1, 1, _alphacolor2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Jugando == true)
        {
            if (Input.GetMouseButton(0))
            {
                onMouseClick();
            }

            if (_alphacolor >= 1f)
            {
                _alphacolor = 1f;
            }
            else
            {
                _alphacolor = _alphacolor + 0.005f;

            }

            if (_alphacolor2 <= 0f) { _alphacolor2 = 0; }
            else { _alphacolor2 = _alphacolor2 - 0.005f; }

            if (_alphacolor <= 0f && _alphacolor2 >= 1f)
            {
                Jugando = false;
                FindObjectOfType<_mascaraTimer>().Ganar();
                _texto.text = "¡Ganaste!";
            }

            _mascara.color = new Color(1, 1, 1, _alphacolor);
            _cerdo.color = new Color(1, 1, 1, _alphacolor2);
        }

        if(Jugando == false) { _otroTimer -= 1 * Time.deltaTime; }

        if (_otroTimer <= 0)
        {
            _otroTimer = 5;
            Jugando = true;
        }
    }
    void onMouseClick()
    {
        AuidoScript.instance.Play("CerdoTap");
        _alphacolor = _alphacolor - 0.018f;
        _alphacolor2 = _alphacolor2 + 0.018f;
    }
    public void Perder()
    {
        Jugando = false;
    }
}
