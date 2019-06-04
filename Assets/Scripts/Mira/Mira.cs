using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mira : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject BullettHoll1;
    public GameObject BullettHoll2;
    private float DirX;
    private float DirY;
    public bool Jugando;
    public float MoveSpeed;

    void Start()
    {
        Jugando = true;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        MouseClick();
        if (Jugando)
        {
            DirX = Input.acceleration.x * MoveSpeed;
            DirY = Input.acceleration.y * MoveSpeed;
            //transform.position  = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);

        }
    }

    void FixedUpdate()
    {
        if (Jugando)
        {
            rb.velocity = new Vector2(DirX, DirY);
        }
    }
    void MouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject BalaACrear;
            int Balla = Random.Range(0, 3);
            if (Balla == 1)
            {
                BalaACrear = BullettHoll1;
            }
            else
            {
                BalaACrear = BullettHoll2;
            }

            //GameObject Ballllllllllla = Instantiate(BalaACrear);
        }
    }

}
