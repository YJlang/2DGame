using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_CreatePrefab : MonoBehaviour
{
    public GameObject newPrefab; //인스펙터 창에서 직접 할당 -프리펩 할당

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(
                Input.mousePosition + //(x, y)
                Camera.main.transform.forward //(0, 0, 1)
                //(x, y, 1)
                //pos = (x, y, 1)
                );
            pos.z = -5; //(x, y, -5) 최종 좌표점 (생성지점)
            //프리펩 생성
            GameObject newGameObject = Instantiate(newPrefab) as GameObject;
            newGameObject.transform.position = pos;
        }
    }
}
