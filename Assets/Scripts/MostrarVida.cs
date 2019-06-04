using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarVida : MonoBehaviour
{
    public Text __vida;

    // Start is called before the first frame update
    void Start()
    {
        __vida.text = Vida._vida.ToString();
    }
}
