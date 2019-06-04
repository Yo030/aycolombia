using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class DESARROLLADOR : MonoBehaviour
{

    [SerializeField]
    private GameObject _EsteObjeto;
    public GameObject _Ganar;
    public GameObject _Perder;
    public GameObject _PerderFinal;
    public GameObject _OtroJuego;
    public GameObject _Reinuciar;
    public GameObject _ReiniciarLogros;
    public GameObject _PararTiempo;
    public GameObject _Ocultar;
    public GameObject _Aparecer;
    int PararBarra = 1;

    void Start()
    {

        if (PlayerConfig.OpcionesDeDesarollador == false)
        {
            _EsteObjeto.SetActive(false);
        }
        if (PlayerConfig.OpcionesDeDesarollador == true)
        {
            _EsteObjeto.SetActive(true);
        }
    }

    public void Ocultar_Aparecer()
    {
        if (Vida.OpcionDesarrollador == -1)
        {
            Vida.OpcionDesarrollador = Vida.OpcionDesarrollador *-1;
        }

        else if (Vida.OpcionDesarrollador == 1)
        {
            Vida.OpcionDesarrollador = Vida.OpcionDesarrollador * -1;
        }
    }

    public void RestablecerLogros()
    {
            PlayerPrefs.SetInt("Colecionable_1", 0);
            PlayerPrefs.SetInt("Colecionable_2", 0);
            PlayerPrefs.SetInt("Colecionable_3", 0);
            PlayerPrefs.SetInt("Colecionable_4", 0);
            PlayerPrefs.SetInt("Colecionable_5", 0);
            PlayerPrefs.SetInt("Colecionable_6", 0);
            PlayerPrefs.SetInt("Colecionable_7", 0);
            PlayerPrefs.SetInt("Colecionable_8", 0);
            PlayerPrefs.SetInt("Colecionable_9", 0);
            PlayerPrefs.SetInt("Colecionable_10", 0);
            PlayerPrefs.SetInt("Colecionable_11", 0);
            PlayerPrefs.SetInt("Colecionable_12", 0);

            PlayerPrefs.SetInt("Colecionable_1_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_2_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_3_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_4_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_5_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_6_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_7_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_8_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_9_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_10_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_11_BOOL", 0);
            PlayerPrefs.SetInt("Colecionable_12_BOOL", 0);

            PlayerPrefs.SetInt("Huachicol_Contador", 0);
            PlayerPrefs.SetInt("Peña_Contador", 0);
        
        }


    public void PararTiempo(GameObject __BarraDeTiempo)
    {

        PararBarra = PararBarra*-1;
        if (PararBarra == 1)
        {
            __BarraDeTiempo.SetActive(true);
        }
        if (PararBarra== -1)
        {
            __BarraDeTiempo.SetActive(false);
        }
        
    }
    
    void Update()
    {
        if (Vida.OpcionDesarrollador == 1)
        {
            _Ganar.SetActive(false);
            _Perder.SetActive(false);
            _PerderFinal.SetActive(false);
            _OtroJuego.SetActive(false);
            _Reinuciar.SetActive(false);
            _ReiniciarLogros.SetActive(false);
            _Aparecer.SetActive(true);
            _Ocultar.SetActive(false);
            _PararTiempo.SetActive(false);
        }


        if (Vida.OpcionDesarrollador == -1)
        {
            _Ganar.SetActive(true);
            _Perder.SetActive(true);
            _PerderFinal.SetActive(true);
            _OtroJuego.SetActive(true);
            _Reinuciar.SetActive(true);
            _ReiniciarLogros.SetActive(true);
            _Aparecer.SetActive(false);
            _Ocultar.SetActive(true);
            _PararTiempo.SetActive(true);
        }
    }
}
