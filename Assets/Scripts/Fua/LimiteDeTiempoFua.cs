using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LimiteDeTiempoFua : MonoBehaviour
{
    Image BarraTiempo;
    public float TiempoDeJeugo = 10;                    //TIEMPO DE JUEGO ES 10 SEGUNDO PREDETERMINADAMENTE
    public float TiempoRestante;                               //TIEMPO QUE QUEDA
    bool TiempoActivo = true;
    public GameObject Jugador;
    private bool jugando = true;
    public float TiempoParaProximaEscena;
    public GameObject PerdisteTxt;

    //Movimiento ControladorMovimiento;

    // Start is called before the first frame update
    void Start()
    {
        BarraTiempo = GetComponent<Image>();            //AGGARA EL SPRITE DEL TIEMPO
		TiempoDeJeugo = TiempoDeJeugo+Vida.ResterTiempo;
        TiempoRestante = TiempoDeJeugo;                 //SE ASIGNA EL TIEMPO
    }

    // Update is called once per frame
    void Update()
    {
        if (TiempoRestante > 0 && jugando == true)        //LO QUE SUCEDE MIENTRAS AUN HAY TIEMPO
        {
            TiempoRestante -= 1 * Time.deltaTime;
            BarraTiempo.fillAmount = TiempoRestante / TiempoDeJeugo;
        }

        if (TiempoRestante <= 0)      //LO QUE SUCEDE CUANDO SE ACAVA EL TIEMPO
        {
            jugando = false;
            TiempoParaProximaEscena -= Time.deltaTime * 1;
            Jugador.GetComponent<Ajitar>().enabled = false;
            PerdisteTxt.SetActive(true);
        }


        if (TiempoParaProximaEscena <= 0)
        {
            SceneManager.LoadScene("Sc_Perder");
        }

    }
}
