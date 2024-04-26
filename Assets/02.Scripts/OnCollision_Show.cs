using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class OnCollision_Show : MonoBehaviour

{

    // �浹�� ��� ������Ʈ�� �̸��� �����ϴ� �����Դϴ�.

    public string targetObjectName;

    // �浹 �� Ȱ��ȭ�� ������Ʈ�� �̸��� �����ϴ� �����Դϴ�.

    public string showObjectName;

    private Renderer PlayerOut;

    // ������ Ȱ��ȭ�� ������Ʈ�� ������ GameObject �����Դϴ�.

    GameObject showObject;

    // ���� ������Ʈ�� ���۵� �� �� �� ȣ��˴ϴ�.

    void Start()

    {

        // showObjectName�� �ش��ϴ� ������Ʈ�� ã�Ƽ� showObject�� �Ҵ��մϴ�.

        showObject = GameObject.Find(showObjectName);

        // ������ ���۵� �� showObject�� ��Ȱ��ȭ�մϴ�.

        showObject.SetActive(false);

    }

    // �浹�� �����Ǿ��� �� ȣ��˴ϴ�.

    void OnCollisionEnter2D(Collision2D collision)

    {

        // �浹�� ������Ʈ�� �̸��� targetObjectName�� ������ Ȯ���մϴ�.

        if (collision.gameObject.name == targetObjectName)

        {

            // �浹�� ������Ʈ�� �̸��� targetObjectName�� ���ٸ�

            // showObject�� Ȱ��ȭ�մϴ�.

            showObject.SetActive(true);

        }

    }

}