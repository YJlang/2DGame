using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obake_HP : MonoBehaviour
{
    //ü��
    public int health = 3;

    //ü�� ���� �Լ�
    public void DecreaseHealth()
    {
        health--;
        if(health <= 0)
        {
            DestroyObject();
        }
    }

    //������Ʈ �ı� �Լ�
    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
