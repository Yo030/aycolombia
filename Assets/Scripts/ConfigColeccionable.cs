using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ConfigColeccionable : MonoBehaviour
{
    public Sprite noDisponible;

    public Button coleccionble1;
    public Text titulo_1;
    public Text contenido_1;
    public Sprite colec_1;

    public Button coleccionble2;
    public Text titulo_2;
    public Text contenido_2;
    public Sprite colec_2;

    public Button coleccionble3;
    public Text titulo_3;
    public Text contenido_3;
    public Sprite colec_3;

    public Button coleccionble4;
    public Text titulo_4;
    public Text contenido_4;
    public Sprite colec_4;

    public Button coleccionble5;
    public Text titulo_5;
    public Text contenido_5;
    public Sprite colec_5;

    public Button coleccionble6;
    public Text titulo_6;
    public Text contenido_6;
    public Sprite colec_6;

    public Button coleccionble7;
    public Text titulo_7;
    public Text contenido_7;
    public Sprite colec_7;

    public Button coleccionble8;
    public Text titulo_8;
    public Text contenido_8;
    public Sprite colec_8;

    public Button coleccionble9;
    public Text titulo_9;
    public Text contenido_9;
    public Sprite colec_9;

    public Button coleccionble10;
    public Text titulo_10;
    public Text contenido_10;
    public Sprite colec_10;


    void Start()
    {
       
        //-----------------------------------------
        AuidoScript.instance.Play("Colecionables");
        AuidoScript.instance.Set_Volume("Colecionables", 100f);
        AuidoScript.instance.Set_Volume("Marcha", 0f);
        //----------------------------------------

        if ( PlayerPrefs.GetInt("Colecionable_1") == 1) //alcalde
        {
            titulo_1.text = "Cartel de ¨Se busca¨";
            contenido_1.text = "Tan grandote y tan desubicado.";
            coleccionble1.GetComponent<Image>().sprite = colec_1; 
            
        }

        if (PlayerPrefs.GetInt("Colecionable_2") == 1) //bronx
        {
            titulo_2.text = "Puñal";
            contenido_2.text = "¿Tu mamá sabe coser? que cosa ésta.";
            coleccionble2.GetComponent<Image>().sprite = colec_2; 
        }

        if (PlayerPrefs.GetInt("Colecionable_3") == 1) //coca
        {
            titulo_3.text = "Cocaina";
            contenido_3.text = "¿Un lineazo o qué?";
            coleccionble3.GetComponent<Image>().sprite = colec_3;
        }

        if (PlayerPrefs.GetInt("Colecionable_4") == 1) //escobar
        {
            titulo_4.text = "Balas";
            contenido_4.text = "He aquí las balas de patrón.";
            coleccionble4.GetComponent<Image>().sprite = colec_4; 
        }

        if (PlayerPrefs.GetInt("Colecionable_5") == 1) //esmeraldas
        {
            titulo_5.text = "Esmeralda";
            contenido_5.text = "Cuidado por donde pisas, puede estar enterrado algo de valor.";
            coleccionble5.GetComponent<Image>().sprite = colec_5;
        }

        if (PlayerPrefs.GetInt("Colecionable_6") == 1) //mascara
        {
            titulo_6.text = "Mascara";
            contenido_6.text = "Detrás de tu gobernante puede haber un animal.";
            coleccionble6.GetComponent<Image>().sprite = colec_6;
        }

        if (PlayerPrefs.GetInt("Colecionable_7") == 1) //nino
        {
            titulo_7.text = "Bla Bla Bla";
            contenido_7.text = "Peguelo, gonorrea, peguelo.";
            coleccionble7.GetComponent<Image>().sprite = colec_7;
        }

        if (PlayerPrefs.GetInt("Colecionable_8") == 1) //titere
        {
            titulo_8.text = "Titere";
            contenido_8.text = "Él es el digno de portar las cuerdas de Uribe.";
            coleccionble8.GetComponent<Image>().sprite = colec_8;
        }

        if (PlayerPrefs.GetInt("Colecionable_9") == 1) //uribe
        {
            titulo_9.text = "Oro";
            contenido_9.text = "¿Qué cuánto le roba al país?";
            coleccionble9.GetComponent<Image>().sprite = colec_9;
        }

        if (PlayerPrefs.GetInt("Colecionable_10") == 1) // sayayines
        {
            titulo_10.text = "Esposas";
            contenido_10.text = "Vamos a buscar a los Sayayines del Bronx.";
            coleccionble10.GetComponent<Image>().sprite = colec_10;
        }

    }


}
