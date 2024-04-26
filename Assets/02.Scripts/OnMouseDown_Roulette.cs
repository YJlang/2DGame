using UnityEngine;

public class OnMouseDown_Roulette : MonoBehaviour
{
    public float maxSpeed = 0;
    public float scaleSpeed = 0.01f;
    public float maxScale = 2f;
    public float minScale = 0.5f;

    private float speed = 0;
    private bool rotateClockwise = true;

    void OnMouseDown()
    {
        speed = maxSpeed;
        rotateClockwise = !rotateClockwise;
    }

    void FixedUpdate()
    {
        speed *= 0.97f;

        if (rotateClockwise)
        {
            transform.Rotate(0, 0, speed);
            ScaleUp();
        }
        else
        {
            transform.Rotate(0, 0, -speed);
            ScaleDown();
        }

        Debug.Log(speed);
    }

    void ScaleUp()
    {
        if (transform.localScale.x < maxScale)
        {
            transform.localScale += Vector3.one * scaleSpeed;
        }
    }

    void ScaleDown()
    {
        if (transform.localScale.x > minScale)
        {
            transform.localScale -= Vector3.one * scaleSpeed;
        }
    }
}