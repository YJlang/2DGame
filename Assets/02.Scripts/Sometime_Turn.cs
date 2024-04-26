using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_Turn : MonoBehaviour
{
    public float angle = 90;
    public int maxCount = 50;
    private int count;

    void Start()
    {
        count = 0;
    }

    void FixedUpdate()
    {
        count += 1; //시간이라는 개념을 count로 구현
        if(count > maxCount)
        {
            this.transform.Rotate(0, 0, angle); //angle에 대한 값을 z축
            count = 0;
        }
    }
}
