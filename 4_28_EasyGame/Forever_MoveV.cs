using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_MoveV : MonoBehaviour
{
    public float speed = -1;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, speed / 50, 0);
    }
}
