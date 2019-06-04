using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitereColition : MonoBehaviour
{
    public float CoolDown;
    public BoxCollider2D BoxCol;
    public GameObject Titere;
    public Rigidbody2D rb2d;
    public GameObject TxtGanar;
    public GameObject TiempoTitere;
    private float CoolDownStartTime;
    private int Contador;

    void Start()
    {
        CoolDownStartTime = CoolDown;
        rb2d = Titere.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MouseClick();
        if (CoolDown > 0)
        {
            CoolDown -= Time.deltaTime * 1;
        }

        if (CoolDown < 0)
        {
            BoxCol.enabled = false;
        }

        if (Contador >= 5)
        {
            Ganador();
        }
    }

    void MouseClick()
    {
        if (Input.GetMouseButtonUp(0))
        {
            BoxCol.enabled = true;
            CoolDown = CoolDownStartTime;
        }
    }

    void Ganador()
    {
            rb2d.gravityScale = 10;
            TiempoTitere.SetActive(false);
            TxtGanar.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.name)
        {
            case "R1":
                Destroy(col.gameObject);
                Contador++;
                break;
            case "R2":
                Destroy(col.gameObject);
                Contador++;
                break;
            case "R3":
                Destroy(col.gameObject);
                Contador++;
                break;
            case "R4":
                Destroy(col.gameObject);
                Contador++;
                break;
            case "R5":
                Destroy(col.gameObject);
                Contador++;
                break;
        }
    }

}

