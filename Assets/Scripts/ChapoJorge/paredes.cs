using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paredes : MonoBehaviour
{
    public Rigidbody2D rb;

    public float velocidad_de_encogimiento = 3f;

    // Use this for initialization
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * velocidad_de_encogimiento * Time.deltaTime;
        if (transform.localScale.x <= .05f)
        {
            Destroy(gameObject);
        }
    }
}
