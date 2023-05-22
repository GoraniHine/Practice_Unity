using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_Move : MonoBehaviour
{
    public float speed = 2;

    float vx = 0;
    float vy = 0;
    bool leftFlag = false;
    Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        vy = 0;

        if(Input.GetKey("right"))
        {
            vx = speed;
            leftFlag = false;
        }
        if (Input.GetKey("left"))
        {
            vx = -speed;
            leftFlag = true;
        }

    }

    void FixedUpdate()
    {
        rbody.velocity = new Vector2(vx, vy);
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
}
