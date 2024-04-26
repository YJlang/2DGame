using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_RandomCreatePrefab : MonoBehaviour
{
    public GameObject newPrefab; //프리펩 할당
    public float intervalSec = 1; //1초

    void Start()
    {
        //Invoke("CreatePrefab", intervalSec); //함수 명(함수 포인터), Invoke 함수는 intervalSec만큼 인스턴스 생성하고 끝
        InvokeRepeating("CreatePrefab", 5, intervalSec); //몇 초 간격으로 생성할건지
    }

    void CreatePrefab()
    {
        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;
        Vector3 newPos = this.transform.position;

        newPos.x += Random.Range(-area.x / 2, area.x / 2);
        newPos.y += Random.Range(-area.y / 2, area.y / 2);

        GameObject newGameObject = Instantiate(newPrefab) as GameObject; //프리펩생성
        newGameObject.transform.position = newPos;
    }
}
