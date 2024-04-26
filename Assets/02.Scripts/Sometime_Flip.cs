using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_Flip : MonoBehaviour
{
    public int maxCount = 50;
    private int count = 0;
    private bool flipFlag = false;

    void FixedUpdate()
    {
        count += 1;
        if(count >= maxCount)
        {
            this.transform.Rotate(0, 0, 180);
            count = 0;
            flipFlag = !flipFlag;
            GetComponent<SpriteRenderer>().flipY = flipFlag;
        }
    }
}
