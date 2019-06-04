using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _manager_Edgar : MonoBehaviour
{
    public GameObject llenando_azul;
    public GameObject circulo_azul;
    public GameObject llenando_rojo;
    public GameObject circulo_rojo;
    public GameObject llenando_verde;
    public GameObject circulo_verde;

    public Text texto;

    public float _otroTimer = 3f;
    public float _timer = 1.5f;

    public int _random;

    public bool accion;
    public bool Jugando;

    Vector3 LA_temp;
    Vector3 CA_temp;
    Vector3 CA_temp_estandar;
    Vector3 LR_temp;
    Vector3 CR_temp;
    Vector3 CR_temp_estandar;
    Vector3 LV_temp;
    Vector3 CV_temp;
    Vector3 CV_temp_estandar;

    private void Awake()
    {
        llenando_azul.SetActive(false);
        llenando_rojo.SetActive(false);
        llenando_verde.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        accion = false;

        LA_temp = llenando_azul.transform.localScale;
        CA_temp = circulo_azul.transform.localScale;
        CA_temp_estandar = circulo_azul.transform.localScale;
        LR_temp = llenando_rojo.transform.localScale;
        CR_temp = circulo_rojo.transform.localScale;
        CR_temp_estandar = circulo_rojo.transform.localScale;
        LV_temp = llenando_verde.transform.localScale;
        CV_temp = circulo_verde.transform.localScale;
        CV_temp_estandar = circulo_verde.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Jugando == true)
        {
            if (accion == true)
            {
                if (Input.GetMouseButton(0))
                {
                    if (CA_temp.x >= LA_temp.x - 4.25f && CA_temp.y >= LA_temp.y - 4.25f)
                    {
                        accion = false;
                        llenando_azul.SetActive(false);
                        llenando_rojo.SetActive(false);
                        llenando_verde.SetActive(false);
                        CA_temp = CA_temp_estandar;
                        CR_temp = CR_temp_estandar;
                        CV_temp = CV_temp_estandar;
                    }
                    else
                    {
                        CA_temp.x += .3f * Time.deltaTime;
                        CA_temp.y += .3f * Time.deltaTime;
                        CR_temp.x += .3f * Time.deltaTime;
                        CR_temp.y += .3f * Time.deltaTime;
                        CV_temp.x += .3f * Time.deltaTime;
                        CV_temp.y += .3f * Time.deltaTime;
                    }
                }
                if (Input.GetMouseButtonUp(0))
                {
                    texto.text = "¡Perdiste!";
                    perder();
                }
            }
            else
            {
                if (_timer > 0)
                {
                    _timer -= 1 * Time.deltaTime;
                }
                else
                {
                    accion = true;
                    _random = Random.Range(1, 3);
                    _Random();
                    _timer = 1.5f;
                }
            }


            circulo_azul.transform.localScale = CA_temp;
            circulo_rojo.transform.localScale = CR_temp;
            circulo_verde.transform.localScale = CV_temp;
        }

        if (Jugando == false) { _otroTimer -= 1 * Time.deltaTime; }

        if (_otroTimer <= 0)
        {
            texto.text = " ";
            _otroTimer = 5;
            Jugando = true;
        }
    }

    void _Random()
    {
        

        switch (_random)
        {
            case 1:
                llenando_azul.SetActive(true);
                return;
            case 2:
                llenando_rojo.SetActive(true);
                return;
            case 3:
                llenando_verde.SetActive(true);
                return;
        }
    }

    public void perder()
    {
        Jugando = false;
        FindObjectOfType<_timer_Edgar>().Perder();
    }
    public void ganar()
    {
        Jugando = false;
    }
}
