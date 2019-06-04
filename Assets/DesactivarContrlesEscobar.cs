using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarContrlesEscobar : MonoBehaviour
{
    public Collider2D m_Collider;


    void Start()
    {
        m_Collider.enabled = false;
    }
}
