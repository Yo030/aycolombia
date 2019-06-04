using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float X;
    public float spe = 350f;
    public float force = 0;
    int change = 0;
    public float TiempoDeCambio = 0;
    public float min = 1.5f;
    public float max = 2.5f;
    public bool Jugando = true;
    public bool TimeUp = false;
    public bool ganador = false;

    public string NombreObjeto = "Tiempo";                                                          //NOMBRE DEL OBJETO QUE TIENE ELL SCRIPT DE *****TimeLimit*****
    TimeLimit ScriptTiempo;

    public GameObject TextGanador;
    public GameObject TextPerdedor;

    private void Start()
    {
        TiempoDeCambio = Random.Range(min, max);
        spe = Random.Range(150f, 250f);

        GameObject otro = GameObject.Find(NombreObjeto);      //ENCUENTRA AL CONTROLADOR
        ScriptTiempo = otro.GetComponent<TimeLimit>();                            //ENCUENTRA EL SCRIPT DEL CONTROLADOR       

    }


    void Update()
    {
        if (Jugando == true)
        {
            TiempoDeCambio -= 1 * Time.deltaTime;                                                   //TIEMPO PARA QUE CAMBIE DE DIRECCION
            X = -1 * Input.acceleration.x;                                                          //***** EL -1 ES PARA QUE SE PUEDA JUGAR EN MODO *LANDSCAPE IZQUIERDO* SI SE QUIERE DEL OTRO LADO SUBSTITUIR POR 1*****
            transform.Rotate(Vector3.forward * (X * spe) * Time.deltaTime);                         //SE MUEVA DEACUERDO A LA VELOCIDAD DE X
        }
        if (TimeUp == true)                                                                         //CUANDO SE ACAVA EL TIEMPO *****ES LLAMADO SOLO POR EL SCRIPT DE TIEMPO*****
        {
            Perder();
        }

        if (ganador == true)
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
    }

    void Ganar()                                                                                    //LO QUE SUSEDE CUANDO GANA
    {
        Debug.Log("Ganador");
        //Jugando = false;
        //TextGanador.SetActive(true);
        ScriptTiempo.Ganar();
    }

    void Perder()                                                                                   //LO QUE SUSEDE CUANDO PIERDE
    {
        Debug.Log("PERDEDOR");
        Jugando = false;
        //ScriptTiempo.Jugando = false;
        ScriptTiempo.SiguientePerder();
        //TextPerdedor.SetActive(true);
    }

    void Tiempo()
    {
        if (Jugando == true)
        {
            change = Random.Range(-1, 2);                                                           //CAMBIA DE DIRECCION EN LA QUE SE MUEVE
            force = Random.Range(75f, 125f);                                                        //CAMBIA LA VELOCIDAD A LA QUE SE MUEVE

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
