using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RomperCaguama2 : MonoBehaviour
{
    public Image Caguama2;
    public GameObject CaguamaRota2;
    //public Image CaguamaRota2;

    void Awake()
    {
        Caguama2 = GetComponent<Image>();

        switch (Vida._vida)
        {
            case 2:
                Caguama2.enabled = false;
                CaguamaRota2.SetActive(true);
                break;

            case 1:
                Caguama2.enabled = false;
                CaguamaRota2.SetActive(true);
                break;
        }
    }

}
