using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botella_Script : MonoBehaviour
{
    private Rigidbody2D _botella;

    public float _velocity;

    public bool _derecha;

    public float _otroTimer = 3f;
    public bool _jugando;

    // Start is called before the first frame update
    void Start()
    {
        _botella = GetComponent<Rigidbody2D>();
        _derecha = true;
        _jugando = false;
        _botella.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(_jugando == true)
        {
            if (_derecha)
            {
                _botella.velocity = new Vector2(-_velocity, 0);
            }
            else
            {
                _botella.velocity = new Vector2(_velocity, 0);
            }
        }

        _otroTimer -= 1 * Time.deltaTime;

        if (_otroTimer <= 0)
        {
            _otroTimer = 0;
            _jugando = true;
        }


    }

    public void onCollide()
    {
        if (_derecha)
        {
            _derecha = false;
        }
        else
        {
            _derecha = true;
        }
    }

    public void _Perder()
    {
        _jugando = false;
    }
}
