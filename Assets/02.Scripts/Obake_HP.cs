using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obake_HP : MonoBehaviour
{
    //체력
    public int health = 3;

    //체력 감소 함수
    public void DecreaseHealth()
    {
        health--;
        if(health <= 0)
        {
            DestroyObject();
        }
    }

    //오브젝트 파괴 함수
    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
