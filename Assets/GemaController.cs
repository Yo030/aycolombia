using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemaController : MonoBehaviour
{
    public GameObject Gema;
    public float TiempoMin;
    public float TiempoMax;
    public float TiempoDeSpawn;


    // Update is called once per frame
    void Update()
    {
        TiempoDeSpawn -= Time.deltaTime * 1;
        if (TiempoDeSpawn < 0)
        {
            Instantiate(Gema, new Vector3(this.transform.position.x, this.transform.position.y, 0), Quaternion.identity);
            TiempoDeSpawn = TiempoDeEspera(TiempoMin, TiempoMax);
        }
    }

    float TiempoDeEspera(float _min, float _max)
    {
        float numRandom;
        numRandom = Random.Range(_min, _max);
        return numRandom;
    }
}
