using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_CreatePrefab : MonoBehaviour
{
    public GameObject newPrefab; //�ν����� â���� ���� �Ҵ� -������ �Ҵ�

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
            pos.z = -5; //(x, y, -5) ���� ��ǥ�� (��������)
            //������ ����
            GameObject newGameObject = Instantiate(newPrefab) as GameObject;
            newGameObject.transform.position = pos;
        }
    }
}
