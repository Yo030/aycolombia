using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuarteController : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    void Update()
    {
        MirarHaciaElMouse();
        MoverHaciaElMouse();     
    }

    void MirarHaciaElMouse()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
    }

    void MoverHaciaElMouse()
    {

        if (Input.GetMouseButton(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = 0;

            float step = moveSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, mousePosition, step);
        }
    }
}
