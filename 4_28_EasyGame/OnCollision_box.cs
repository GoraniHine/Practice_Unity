using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_box : MonoBehaviour
{
    public string targetObjectName;
    public GameObject newPrefab;

    public float offsetX = 1;
    public float offsetY = 1;
    bool pushFlag = false;

    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            if (pushFlag == false)
            {
                 pushFlag = true;
                 Vector3 area = this.GetComponent<SpriteRenderer>().bounds.size;
                 Vector3 newPos = this.transform.position;


                    
                 offsetX = Random.Range(-3, 3);
                 offsetY = Random.Range(3, 6);

                 newPos.x += offsetX;
                 newPos.y += offsetY;
                 newPos.z = -5;

                 GameObject newGameObject = Instantiate(newPrefab) as GameObject;
                 newGameObject.transform.position = newPos;

            }
            else
            {
                pushFlag = false;
            }
        }
    }
}
