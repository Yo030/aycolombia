using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliciasController : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public GameObject Duarte;
    void Update()
    {
        MoverHaciaElMouse();
    }

    void MoverHaciaElMouse()
    {

          float step = moveSpeed * Time.deltaTime;
          transform.position = Vector3.MoveTowards(transform.position, Duarte.transform.position, step);
        
    }

}
