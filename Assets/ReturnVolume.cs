using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnVolume : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AuidoScript.instance.Set_Volume("Marcha", 100f);
        AuidoScript.instance.Set_Volume("Colecionables", 0f);
    }
}
