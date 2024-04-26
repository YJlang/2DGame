using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private Vector3 teleportPosition = new Vector3(10.2f, -0.8f, 2.4f); // �����̵��� ��ǥ�� ����, ���������� ��ó ��ġ

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Respawn"))
        {
            // �����۰� �浹���� �� �÷��̾ ������ ��ǥ�� �����̵���ŵ�ϴ�.
            transform.position = teleportPosition;
        }
    }
}