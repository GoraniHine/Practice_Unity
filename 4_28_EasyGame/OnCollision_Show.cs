using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_Show : MonoBehaviour
{
    public string targetObjectName;
    public string showObjectName;
    GameObject showObject;

    void Start()
    {
        showObject = GameObject.Find(showObjectName);
        showObject.SetActive(false);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
            {
                showObject.SetActive(true);
            }
    }
}
