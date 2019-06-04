using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class CreditsController : MonoBehaviour
{
    int clave;
    string myname;
    public GameObject ProfeSecreto;

    private void Start()
    {
        clave = 0;
    }
    public void TogglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }


    public void claveSecreta()
    {
        myname = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(myname);
        Debug.Log(clave);
        if (clave == 0 && myname == "Button_Criss")
        {
            clave = clave + 1;
            Debug.Log(clave);
        }
     
        if (clave == 1 && myname == "Button_Pablo")
        {
            clave = clave + 1;
            Debug.Log(clave);
        }
      
        if (clave == 2 && myname == "Button_Aldo")
        {
            clave = clave + 1;
            Debug.Log(clave);
        }
       
        if (clave == 3 && myname == "Button_Sergio")
        {
            
            ProfeSecreto.SetActive(!ProfeSecreto.activeSelf);
            Debug.Log(clave);
            clave = 0;
        }
     
    }

}
