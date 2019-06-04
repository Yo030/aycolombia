using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Niero_Collider : MonoBehaviour
{
    public Text winText;

    private Animator Niero_Anim;

    public GameObject Tiempo;

    private int cont = 1;

    public bool Callado;

    public float _otroTimer = 3f;

    public bool Jugando;

    private void Start()
    {

        Niero_Anim = GetComponent<Animator>();

        Callado = true;
        Jugando = false;
    }

    private void Update()
    {
        if (Jugando == true)
        {
            Callado = false;
        }

        if (Jugando == false) { _otroTimer -= 1 * Time.deltaTime; Callado = true; }

        if (_otroTimer <= 0)
        {
            _otroTimer = 5;
            Jugando = true;
        }

        Niero_Anim.SetBool("Callado", Callado);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Jugando = false;
            AuidoScript.instance.Stop("Blablabla");
            AuidoScript.instance.Play("Bla_callado");
            AuidoScript.instance.Play("Marcha");
            Tiempo.SetActive(false);
            winText.text = "¡Bien!";
            FindObjectOfType<Niero_Manager>().onLoose();
            //FindObjectOfType<Niero_Timer>().Ganar();
            StartCoroutine(_waitASec());
        }
    }

    IEnumerator _waitASec()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Sc_Ganar");
    }
}
