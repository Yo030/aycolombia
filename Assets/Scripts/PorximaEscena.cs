using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PorximaEscena : MonoBehaviour
{
    public int NumeroRandom;
    //public int NumDeJuegos = 3;

    public void NextScean()
    {
        NumeroRandom = Random.Range(1, 11);
        if (Vida._vida <= 0)
        {
            SceneManager.LoadScene("Sc_MainMenu");
        }


        else if (Vida._vida > 0 )
        {
            if (Vida.CuentaDeNiveles == 3 || Vida.CuentaDeNiveles == 6 || Vida.CuentaDeNiveles == 9)
            {

                SceneManager.LoadScene("Sc_Rapido");

            }

            else
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





                        /*
                        CUANDO AGREGUES OTRA ESCENA TAMBIEN AGREGALO AL

                        EscenaMasRapido ||||||SCRIPT||||||

                         */

                }
            }
        }
        

        /*

        if (Vida._vida > 0)
        {
            SceneManager.LoadScene("GP_1(No te duermaas)");
        }
        */
    }
}
