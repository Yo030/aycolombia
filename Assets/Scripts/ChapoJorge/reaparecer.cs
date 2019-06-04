using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class reaparecer : MonoBehaviour
{
    public float rango_de_reaparicion = 1f;
    public GameObject paredesPrefab;
    private float tiempo_de_reaparicion = 2f;
    
     public Text mecanica;
     public Text instruccion;

    
    // Update is called once per frame
    private void Start()
    {
        mecanica.text = "";
        instruccion.text = "";


    }



    void Update()
    {
        

        if (Time.time >= tiempo_de_reaparicion)
        {
            var angles = transform.rotation.eulerAngles;
            angles.z += Random.Range(0f, 360f);

            Instantiate(paredesPrefab, Vector3.zero, Quaternion.Euler(angles));
            tiempo_de_reaparicion = Time.time + 1f / rango_de_reaparicion;
        }
    }



}
