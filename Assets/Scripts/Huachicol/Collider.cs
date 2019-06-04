using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collider : MonoBehaviour
{
    public Text winText;

    private int cont = 1;

    private void Start()
    {
        cont = PlayerPrefs.GetInt("Huachicol_Contador");
        cont++;
        PlayerPrefs.SetInt("Huachicol_Contador", cont);
        Debug.Log("Huachicol contador es igual a: " + cont);
        if (cont >= 100)
        {
            PlayerPrefs.SetInt("Colecionable_2", 1);
            Debug.Log("Se desbloqueo el Galon de oro");
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            
            AuidoScript.instance.Stop("FugaEff");
            winText.text = "Bien!";
            FindObjectOfType<Timer>().Ganar();
            FindObjectOfType<Player_Manager>().onLoose();
            StartCoroutine(_waitASec());
        }
    }

    IEnumerator _waitASec()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Sc_Ganar");
    }
}
