using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_Rotate : MonoBehaviour
{
    public float angle = 360;
    public float rotateAngle = 0;

    void OnMouseDown()
    {
        rotateAngle = angle;
    }
    void OnMouseUp()
    {
        rotateAngle = 0;
    }
    void FixedUpdate()
    {
        this.transform.Rotate(0, 0, rotateAngle / 50);
    }
}
