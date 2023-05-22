using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_CreaterPrefab : MonoBehaviour
{
    public GameObject newPrefab;
    public string inkey = "space";
    public float offsetX = 1;
    public float offsetY = 1;
    bool pushFlag = false;

    void Update()
    {
        if(Input.GetKey(inkey))
        {
            if(pushFlag == false)
            {
                pushFlag = true;
                Vector3 area = this.GetComponent<SpriteRenderer>().bounds.size;
                Vector3 newPos = this.transform.position;

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
