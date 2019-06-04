using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _bronxFollowScript : MonoBehaviour
{
    private Rigidbody2D Cuchillo;

    public float speed;
    public float _rotationSpeed = 5f;
    public float gravedad;

    public bool vivo;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Cuchillo = GetComponent<Rigidbody2D>();
        Cuchillo.gravityScale = gravedad;

        vivo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (vivo == true)
        {
            Vector2 direction = target.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, _rotationSpeed * Time.deltaTime);

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        
        Cuchillo.gravityScale = gravedad;
    }

    public void OnMouseDown()
    {
        vivo = false;
        gravedad = 1f;
        StartCoroutine(Destroy());
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
