using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_floor : MonoBehaviour
{
    public string targetObjectName;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Destroy(this.gameObject);
        }
    }
}
