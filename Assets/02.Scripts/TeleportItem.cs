using UnityEngine;

public class TeleportItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // �÷��̾�� �浹���� �� �������� ��Ȱ��ȭ�մϴ�.
            gameObject.SetActive(false);
        }
    }
}
