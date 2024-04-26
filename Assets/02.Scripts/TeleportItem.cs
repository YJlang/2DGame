using UnityEngine;

public class TeleportItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // 플레이어와 충돌했을 때 아이템을 비활성화합니다.
            gameObject.SetActive(false);
        }
    }
}
