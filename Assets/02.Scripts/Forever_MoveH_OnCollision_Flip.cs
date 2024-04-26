using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_MoveH_OnCollision_Flip : MonoBehaviour
{
    #region 기존 블럭 코드
    /*public float speed = 0.5f;
    private Rigidbody2D rbody;
    void Start()
    {
        //Rigidbody2D 초기화 코드
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionY;
    }

    void FixedUpdate()
    {
        rbody.velocity = new Vector2(speed, 0);
    }

    //레포트에서 써먹을 것.
    void OnCollisionEnter2D(Collision2D collision)
    {
        speed = -speed;
        this.GetComponent<SpriteRenderer>().flipX = (speed < 0);
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
            collision.rigidbody.velocity = rbody.velocity;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }*/
    #endregion

    public float speed = 2f;
    public float distance = 5f;
    private Vector3 startPosition;
    private Vector3 endPosition;
    private bool isMovingRight = true;

    void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + Vector3.right * distance;
    }

    void Update()
    {
        if (isMovingRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, speed * Time.deltaTime);
            if (transform.position == endPosition)
            {
                isMovingRight = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, speed * Time.deltaTime);
            if (transform.position == startPosition)
            {
                isMovingRight = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
        if (collision.gameObject.name == "other_block2")
        {
            isMovingRight = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
        if (collision.gameObject.name == "other_block1")
        {
            isMovingRight = false;
        }
    }

}
