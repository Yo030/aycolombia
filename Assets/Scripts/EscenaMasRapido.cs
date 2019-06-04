using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaMasRapido : MonoBehaviour
{
    public float TiempoDeEspera;

    public int NumeroRandom;

    void Start()
    {
        NumeroRandom = Random.Range(1, 11);
    }

    void Update()
    {
        TiempoDeEspera -= Time.deltaTime * 1;

        NumeroRandom = Random.Range(1, 9);

        if (TiempoDeEspera < 0)
        {
            switch (NumeroRandom)
            {
                case 1:
                    SceneManager.LoadScene("GP_1(Lost)");
                    break;
                case 2:
                    SceneManager.LoadScene("GP_2(Niero)");
                    break;
                case 3:
                    SceneManager.LoadScene("GP_3(Escobar)");
                    break;
                case 4:
                    SceneManager.LoadScene("GP_4(Mascara)");
                    break;
                case 5:
                    SceneManager.LoadScene("GP_5(Uribe)");
                    break;
                case 6:
                    SceneManager.LoadScene("GP_6(Coca)");
                    break;
                case 7:
                    SceneManager.LoadScene("GP_7(Esmeralda)");
                    break;
                case 8:
                    SceneManager.LoadScene("GP_8(Saiyans)");
                    break;
                case 9:
                    SceneManager.LoadScene("GP_9(Bronx)");
                    break;
                case 10:
                    SceneManager.LoadScene("GP_10(Titere)");
                    break;
            }
        }
    }

}
