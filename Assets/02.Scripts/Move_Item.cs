using UnityEngine;

public class Move_Item : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ�
    public float moveDistance = 2f; // �̵� �Ÿ�

    private Vector3 originalPosition; // ���� ��ġ
    private bool movingLeft = true; // �������� �̵� ������ ����

    void Start()
    {
        originalPosition = transform.position; // �ʱ� ��ġ ����
    }

    void Update()
    {
        // �������� �̵� ���� ���
        if (movingLeft)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime); // �������� �̵�

            // ���� ��ġ���� ���� �Ÿ� �̵������� ���� ��ȯ
            if (transform.position.x <= originalPosition.x - moveDistance)
            {
                movingLeft = false; // ���� ��ȯ
            }
        }
        // ���������� �̵� ���� ���
        else
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime); // ���������� �̵�

            // ���� ��ġ�� ���ƿ����� ���� ��ȯ
            if (transform.position.x >= originalPosition.x)
            {
                movingLeft = true; // ���� ��ȯ
            }
        }
    }
}
