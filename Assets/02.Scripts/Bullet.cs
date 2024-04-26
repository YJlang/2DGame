using UnityEngine;

public class Bullet : MonoBehaviour
{
    // �߻��� �Ѿ� ������Ʈ�� ������ ����
    public GameObject BulletObject;
    // �Ѿ��� Rigidbody2D ������Ʈ�� ������ ����
    private Rigidbody2D rbody;
    // �Ѿ��� �߻� �ӵ��� ������ ����
    public float launchSpeed = 10.0f;

    // ���� ����� Ÿ�� ������Ʈ�� ������ ����
    private GameObject targetObject;

    void Update()
    {
        // �� �����Ӹ��� ����Ǵ� Update �Լ�
        // 'Z' Ű�� ������ �� �Ѿ� �߻�
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // ���� ����� Ÿ�� ������Ʈ ã��
            targetObject = FindNearestTargetObject();

            // Ÿ�� ������Ʈ�� �����ϴ� ���
            if (targetObject != null)
            {
                // �Ѿ� ������Ʈ ���� (BulletObject ������ ���)
                GameObject missile = Instantiate(BulletObject, transform.position, Quaternion.identity);
                // ������ �Ѿ� ������Ʈ�� Rigidbody2D ������Ʈ ��������
                rbody = missile.GetComponent<Rigidbody2D>();

                // �Ѿ��� Ÿ�� ������Ʈ�� ���ϴ� ���� ���
                Vector2 direction = (targetObject.transform.position - transform.position).normalized;
                // ���� �������� �Ѿ˿� ���� ���Ͽ� �߻�
                rbody.AddForce(direction * launchSpeed, ForceMode2D.Impulse);
            }
        }
    }

    // ���� ����� Ÿ�� ������Ʈ�� ã�� �Լ�
    private GameObject FindNearestTargetObject()
    {
        // "Respawn" �±׸� ���� ��� ������Ʈ ã��
        GameObject[] targetObjects = GameObject.FindGameObjectsWithTag("Respawn");
        // ���� ����� Ÿ�� ������Ʈ�� ������ ���� �ʱ�ȭ
        GameObject nearestTarget = null;
        // ���� ����� �Ÿ��� ������ ���� �ʱ�ȭ (���Ѵ�� ����)
        float nearestDistance = Mathf.Infinity;

        // ã�� ��� Ÿ�� ������Ʈ�� ���� �ݺ�
        foreach (GameObject target in targetObjects)
        {
            // ���� ������Ʈ�� Ÿ�� ������Ʈ ������ �Ÿ� ���
            float distance = Vector2.Distance(transform.position, target.transform.position);
            // ���� �Ÿ��� ��������� ���� ����� �Ÿ����� ���� ���
            if (distance < nearestDistance)
            {
                // ���� ����� �Ÿ� ����
                nearestDistance = distance;
                // ���� ����� Ÿ�� ������Ʈ ����
                nearestTarget = target;
            }
        }

        // ���� ����� Ÿ�� ������Ʈ ��ȯ
        return nearestTarget;
    }
}