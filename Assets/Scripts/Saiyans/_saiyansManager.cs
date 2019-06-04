using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _saiyansManager : MonoBehaviour
{
    public GameObject Bton_1;
    public GameObject Bton_2;
    public GameObject Bton_3;
    public GameObject Bton_4;

    public Text _texto;

    public float _otroTimer = 3f;
    public float _timer;
    public int _Random;
    public int _counter = 0;

    public bool Jugando;

    public bool Buttons_bool;
    private bool Bton_1_bool;
    private bool Bton_2_bool;
    private bool Bton_3_bool;
    private bool Bton_4_bool;

    // Start is called before the first frame update
    void Start()
    {
        Bton_1.SetActive(false);
        Bton_2.SetActive(false);
        Bton_3.SetActive(false);
        Bton_4.SetActive(false);

        Jugando = false;

        Buttons_bool = true;
        Bton_1_bool = true;
        Bton_2_bool = true;
        Bton_3_bool = true;
        Bton_4_bool = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Jugando == true)
        {
            if (Buttons_bool == true)
            {
                Bton_1.SetActive(false);
                Bton_2.SetActive(false);
                Bton_3.SetActive(false);
                Bton_4.SetActive(false);

                _timer -= 1 * Time.deltaTime;
            }
            if (_timer <= 0)
            {
                Buttons_bool = false;
                _timer = .5f;
                _Random = Random.Range(1, 4);
                Random_Function();
            }
            if (_counter >= 3)
            {
                _texto.text = "¡Ganaste!";
                Jugando = false;
                FindObjectOfType<_saiyansTimer>().Ganar();
            }
        }

        if (Jugando == false) { _otroTimer -= 1 * Time.deltaTime; }

        if (_otroTimer <= 0)
        {
            _texto.text = " ";
            _otroTimer = 5;
            Jugando = true;
        }
    }

    public void perder()
    {
        Jugando = false;
    }

    private void Random_Function()
    {
        switch (_Random)
        {
            case 1:
                Button_1();
                break;
            case 2:
                Button_2();
                break;
            case 3:
                Button_3();
                break;
            case 4:
                Button_4();
                break;
        }
    }

    public void Buttons_Script()
    {
        if (Jugando == true)
        {
            _counter++;
            Buttons_bool = true;
        }
    }
    private void Button_1()
    {
        Debug.Log("Boton 1");
        Bton_1.SetActive(true);
        Bton_1_bool = false;
        StartCoroutine(B_Secs());
    }
    private void Button_2()
    {
        Debug.Log("Boton 2");
        Bton_2.SetActive(true);
        Bton_2_bool = false;
        StartCoroutine(B_Secs());
    }
    private void Button_3()
    {
        Debug.Log("Boton 3");
        Bton_3.SetActive(true);
        Bton_3_bool = false;
        StartCoroutine(B_Secs());
    }
    private void Button_4()
    {
        Debug.Log("Boton 4");
        Bton_4.SetActive(true);
        Bton_4_bool = false;
        StartCoroutine(B_Secs());
    }
    IEnumerator B_Secs()
    {
        yield return new WaitForSeconds(1f);
        Buttons_bool = true;
    }
}
