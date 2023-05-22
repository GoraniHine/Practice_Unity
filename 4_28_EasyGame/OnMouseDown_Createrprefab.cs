using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_Createrprefab : MonoBehaviour
{

    public GameObject newPrefab;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //���콺 ���ʹ�ư�� ������ ����
        {
            var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition + Camera.main.transform.forward);
            pos.z = -5;
            GameObject newGameObject = Instantiate(newPrefab) as GameObject;
            newGameObject.transform.position = pos;
            
        }
    }
}
