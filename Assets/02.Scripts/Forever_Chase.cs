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
        //별표5개 코드(중요)
        targetObject = GameObject.Find(targetObjectName); //player를 find해서 씬 안에 적용.
        //유령
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void FixedUpdate()
    {
        Vector3 dir = (targetObject.transform.position - this.transform.position).normalized; //유령이 플레이어를 쫒아가는 단위벡터 생성
        float vx = dir.x * speed;
        float vy = dir.y * speed;
        rbody.velocity = new Vector2(vx, vy);//유령의 이동
        //유령 이미지 반전
        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
        Debug.Log("vx : " + vx);
    }
}
