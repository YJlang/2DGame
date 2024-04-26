using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallauto_Move : MonoBehaviour
{
    // 오브젝트가 움직일 수 있는 가장 오른쪽과 왼쪽의 위치를 설정합니다.
    public float rightMax = 100.0f;
    public float leftMax = -100.0f;

    // 현재 오브젝트의 x 좌표와 이동 방향을 저장할 변수를 설정합니다.
    public float currentX;
    public float direction = 10.0f;
    private Rigidbody2D rbody;

    // 게임 오브젝트가 시작될 때 한 번 호출됩니다.
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        // 시작할 때 현재 오브젝트의 x 좌표를 저장합니다.
        currentX = this.transform.position.x;
    }

    // 매 프레임마다 호출됩니다.
    void Update()
    {
        // 현재 x 좌표에 시간에 따라 direction 값에 따라 이동합니다.
        currentX += Time.deltaTime * direction;

        // 만약 오른쪽 최대 위치에 도달했다면
        if (currentX >= rightMax)
        {
            // 오른쪽 최대 위치에 멈추고 방향을 반대로 바꿉니다(왼쪽으로 이동).
            currentX = rightMax;
            direction *= -1; // 이동 방향을 반대로 바꿉니다.
        }
        // 만약 왼쪽 최대 위치에 도달했다면
        else if (currentX <= leftMax)
        {
            // 왼쪽 최대 위치에 멈추고 방향을 반대로 바꿉니다(오른쪽으로 이동).
            currentX = leftMax;
            direction *= -1; // 이동 방향을 반대로 바꿉니다.
        }

        // 새로운 위치로 오브젝트를 이동시킵니다.
        transform.position = new Vector3(currentX, 0, 0);
    }
}
