using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_Chase : MonoBehaviour
{
    public string targetObjectName;
    public float speed = 1;
    private GameObject targetObject;
    private Rigidbody2D rbody;
    void Start()
    {
        //��ǥ5�� �ڵ�(�߿�)
        targetObject = GameObject.Find(targetObjectName); //player�� find�ؼ� �� �ȿ� ����.
        //����
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()
    {
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized; //������ �÷��̾ �i�ư��� �������� ����
        float vx = dir.x * speed;
        float vy = dir.y * speed;
        rbody.velocity = new Vector2(vx, vy);//������ �̵�
        //���� �̹��� ����
        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
        Debug.Log("vx : " + vx);
    }
}
