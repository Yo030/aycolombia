using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parent : MonoBehaviour
{
    private GameObject Padre;
    private GameObject Mira;
    private RectTransform mRectTransform;
    void Awake()
    {
        /*Padre = GameObject.Find("Panel");
        Mira = GameObject.Find("Mira");
        this.transform.SetParent(Padre.transform);
        transform.position = new Vector3(Mira.transform.localPosition.x, Mira.transform.localPosition.x, 0);
        */
    }
}
