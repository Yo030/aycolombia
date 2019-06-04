using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimiento : MonoBehaviour
{
    float X;
    public float spe = 350f;
    public float TiempoParaGanar;
    public bool StartTimer = false;
    public bool Jugando = true;
    public bool Perdio = false;
    public bool TimeUp = false;
    public float TiempoParaCambioDeEcenas;
    float RefTiempoDeReinicio;


    public float force = 0;
    int change = 0;
    public float TiempoDeCambio = 0;
    public float min = 1.5f;
    public float max = 2.5f;

    public float tttttttttttiempo = 0;

    public GameObject TextGanador;
    public GameObject TextPerdedor;

    TiempoDeEsperaaProxEscena Script_TiempoDeEsperaaProxEscena;


    void Start()
    {
        TiempoDeCambio = Random.Range(min, max);
        spe = Random.Range(350f, 500f);

        RefTiempoDeReinicio = TiempoParaGanar;

        AuidoScript.instance.Play("IntroGameEff");
        AuidoScript.instance.Play("Ronquido");
        AuidoScript.instance.Set_Volume("Marcha", 0.25f);

        GameObject otro = GameObject.Find("ControladorDeDerrota/Victoria");
        Script_TiempoDeEsperaaProxEscena = otro.GetComponent<TiempoDeEsperaaProxEscena>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Jugando == true)
        {
            TiempoDeCambio -= 1 * Time.deltaTime;
            X = -1 * Input.acceleration.x;                                                          //***** EL -1 ES PARA QUE SE PUEDA JUGAR EN MODO *LANDSCAPE IZQUIERDO* SI SE QUIERE DEL OTRO LADO SUBSTITUIR POR 1*****
            transform.Rotate(Vector3.forward * (X * spe) * Time.deltaTime);                         //SE MUEVA DEACUERDO A LA VELOCIDAD DE X
        }

        if (TimeUp == true)                                                                         //CUANDO SE ACAVA EL TIEMPO *****ES LLAMADO SOLO POR EL SCRIPT DE TIEMPO*****
        {
            Perder();
        }

        if (StartTimer == true && Jugando == true)
        {
            TiempoParaGanar -= Time.deltaTime * 1;
        }

        if (TiempoParaGanar <= 0)
        {
            Ganar();
        }

    }

    void LateUpdate()
    {
        if (Jugando == true)                                                                        //SE MUEVE SOLO A LA DERECHA O IZQUIERDA
        {
            if (TiempoDeCambio < 0)
            {
                Tiempo();
            }
            transform.Rotate(Vector3.forward * (change * force) * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)                                                         //LO QUE SUSEDE CUANDO COLICIONA
    {
        if (other.name == "GameOver")
        {
            Perder();
        }

        if (other.name == "GameOver")
        {
            Perder();
        }
        
        if (other.name == "Target")
        {
            StartTimer = true;
        }

     }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Target")
        {
            StartTimer = false;
            TiempoParaGanar = RefTiempoDeReinicio;
        }
    }


    public void Perder()
    {
        Jugando = false;
        TextPerdedor.SetActive(true);
        Script_TiempoDeEsperaaProxEscena.Perdio = true;

        Perdio = true;
    }

    public void Ganar()                                                                                    //LO QUE SUSEDE CUANDO GANA
    {
        Jugando = false;
        TextGanador.SetActive(true);
        Script_TiempoDeEsperaaProxEscena.Gano = true;
    }

    void Tiempo()
    {
        if (Jugando == true)
        {
            change = Random.Range(-1, 2);                                                           //CAMBIA DE DIRECCION EN LA QUE SE MUEVE
            force = Random.Range(25f, 40f);                                                        //CAMBIA LA VELOCIDAD A LA QUE SE MUEVE

            if (change == -1 || change == 1 || change == 2)                                         //CUANDO SE ESCOJE LA DIRECCION SE REINICIA EL TIEMPO PARA QUE SE VUELVA A CAMBIAR OTRA VEZ               
            {
                TiempoDeCambio = Random.Range(min, max);
            }

            if (change == 0)                                                                        //SI NO SE MUEVE
            {
                TiempoDeCambio = .5f;                                                               //TIEMPO DE ESPERA PARA QUE SE VUELVA A MOVER
            }
        }
    }


}
