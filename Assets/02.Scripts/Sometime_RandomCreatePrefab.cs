using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_RandomCreatePrefab : MonoBehaviour
{
    public GameObject newPrefab; //������ �Ҵ�
    public float intervalSec = 1; //1��

    void Start()
    {
        //Invoke("CreatePrefab", intervalSec); //�Լ� ��(�Լ� ������), Invoke �Լ��� intervalSec��ŭ �ν��Ͻ� �����ϰ� ��
        InvokeRepeating("CreatePrefab", 5, intervalSec); //�� �� �������� �����Ұ���
    }

    void CreatePrefab()
    {
        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;
        Vector3 newPos = this.transform.position;

        newPos.x += Random.Range(-area.x / 2, area.x / 2);
        newPos.y += Random.Range(-area.y / 2, area.y / 2);

        GameObject newGameObject = Instantiate(newPrefab) as GameObject; //���������
        newGameObject.transform.position = newPos;
    }
}
