using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirUrl : MonoBehaviour
{
    public void _AbrirURL(string URL)
    {
        Application.OpenURL(URL);
    }
}
