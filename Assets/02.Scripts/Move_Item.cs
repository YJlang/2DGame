using UnityEngine;

public class Move_Item : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도
    public float moveDistance = 2f; // 이동 거리

    private Vector3 originalPosition; // 원래 위치
    private bool movingLeft = true; // 왼쪽으로 이동 중인지 여부

    void Start()
    {
        originalPosition = transform.position; // 초기 위치 저장
    }

    void Update()
    {
        // 왼쪽으로 이동 중인 경우
        if (movingLeft)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime); // 왼쪽으로 이동

            // 원래 위치에서 일정 거리 이동했으면 방향 전환
            if (transform.position.x <= originalPosition.x - moveDistance)
            {
                movingLeft = false; // 방향 전환
            }
        }
        // 오른쪽으로 이동 중인 경우
        else
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime); // 오른쪽으로 이동

            // 원래 위치로 돌아왔으면 방향 전환
            if (transform.position.x >= originalPosition.x)
            {
                movingLeft = true; // 방향 전환
            }
        }
    }
}
