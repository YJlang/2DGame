using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallauto_Move : MonoBehaviour
{
    // ������Ʈ�� ������ �� �ִ� ���� �����ʰ� ������ ��ġ�� �����մϴ�.
    public float rightMax = 100.0f;
    public float leftMax = -100.0f;

    // ���� ������Ʈ�� x ��ǥ�� �̵� ������ ������ ������ �����մϴ�.
    public float currentX;
    public float direction = 10.0f;
    private Rigidbody2D rbody;

    // ���� ������Ʈ�� ���۵� �� �� �� ȣ��˴ϴ�.
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        // ������ �� ���� ������Ʈ�� x ��ǥ�� �����մϴ�.
        currentX = this.transform.position.x;
    }

    // �� �����Ӹ��� ȣ��˴ϴ�.
    void Update()
    {
        // ���� x ��ǥ�� �ð��� ���� direction ���� ���� �̵��մϴ�.
        currentX += Time.deltaTime * direction;

        // ���� ������ �ִ� ��ġ�� �����ߴٸ�
        if (currentX >= rightMax)
        {
            // ������ �ִ� ��ġ�� ���߰� ������ �ݴ�� �ٲߴϴ�(�������� �̵�).
            currentX = rightMax;
            direction *= -1; // �̵� ������ �ݴ�� �ٲߴϴ�.
        }
        // ���� ���� �ִ� ��ġ�� �����ߴٸ�
        else if (currentX <= leftMax)
        {
            // ���� �ִ� ��ġ�� ���߰� ������ �ݴ�� �ٲߴϴ�(���������� �̵�).
            currentX = leftMax;
            direction *= -1; // �̵� ������ �ݴ�� �ٲߴϴ�.
        }

        // ���ο� ��ġ�� ������Ʈ�� �̵���ŵ�ϴ�.
        transform.position = new Vector3(currentX, 0, 0);
    }
}
