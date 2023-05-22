using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_Createrprefab : MonoBehaviour
{

    public GameObject newPrefab;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //마우스 왼쪽버튼을 누르는 순간
        {
            var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition + Camera.main.transform.forward);
            pos.z = -5;
            GameObject newGameObject = Instantiate(newPrefab) as GameObject;
            newGameObject.transform.position = pos;
            
        }
    }
}
