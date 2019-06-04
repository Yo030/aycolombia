using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("colission");
        Destroy(this.gameObject);
    }
}
