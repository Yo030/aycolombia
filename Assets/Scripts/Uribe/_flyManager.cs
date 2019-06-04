using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _flyManager : MonoBehaviour
{
    public float Speed;
    private float waitTime;
    public float startWaitTime;
    public float _otroTimer = 3f;

    public Transform[] moveSpots;

    private Animator Fly_Anim;

    private int randomSpot;

    public bool Jugando;
    public bool Quieto;

    // Start is called before the first frame update
    void Start()
    {
        Fly_Anim = GetComponent<Animator>();
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
        Quieto = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Jugando == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, Speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.02f)
            {
                if (waitTime <= 0)
                {
                    randomSpot = Random.Range(0, moveSpots.Length);
                    waitTime = startWaitTime;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
        }
        
        if (Jugando == false) { _otroTimer -= 1 * Time.deltaTime; Quieto = true; }

        if (_otroTimer <= 0)
        {
            Quieto = false;
            _otroTimer = 5;
            Jugando = true;
        }

        Fly_Anim.SetBool("Quieto", Quieto);
    }

    public void Perder()
    {
        Jugando = false;
    }

    private void OnMouseDown()
    {
        if (Jugando == true)
        {
            Debug.Log("AHHHHHHHHHH");
            FindObjectOfType<_UribeManager>().CounterPlusPlus();
            Destroy(gameObject);
        }
    }
}
