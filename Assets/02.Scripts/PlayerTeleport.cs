using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private Vector3 teleportPosition = new Vector3(10.2f, -0.8f, 2.4f); // 순간이동할 좌표를 지정, 보물상자의 근처 위치

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Respawn"))
        {
            // 아이템과 충돌했을 때 플레이어를 지정된 좌표로 순간이동시킵니다.
            transform.position = teleportPosition;
        }
    }
}