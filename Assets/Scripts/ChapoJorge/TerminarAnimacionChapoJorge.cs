using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerminarAnimacionChapoJorge : MonoBehaviour
{
    public float TiempoDeEspera = 2;//EL MISMO TIEMPO QUE DURA LA ANIMACION

    void Update()
    {
        TiempoDeEspera -= Time.deltaTime * 1;
        if (TiempoDeEspera <= 0)
        {
            SceneManager.LoadScene("GP_4(chapo_jorge)");
        }
    }

}
