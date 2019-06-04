using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _bronxPlayerScript : MonoBehaviour
{
    public float _otroTimer = 3f;

    public bool Jugando;
    public bool Quieto;

    private Animator Player_Anim;

    private void Start()
    {
        Player_Anim = GetComponent<Animator>();
        Quieto = true;
    }

    private void Update()
    {
        if (Jugando == false) { _otroTimer -= 1 * Time.deltaTime; Quieto = true; }

        if (_otroTimer <= 0)
        {
            Quieto = false;
            _otroTimer = 5;
            Jugando = true;
        }

        Player_Anim.SetBool("Quieto", Quieto);    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Jugando = false;
        FindObjectOfType<_bronxTimer>().Perder();
    }
}
