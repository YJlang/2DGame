using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_StopGame : MonoBehaviour
{
    #region �����ڵ�
    /*public string targetObjectName;

    void Start()
    {
        Time.timeScale = 1;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Time.timeScale = 0;
        }
    }*/
    #endregion
    public string targetObjectName; // �浹 �� ������ �����ų ��� ������Ʈ�� �̸�
    private Renderer playerRenderer; // �÷��̾��� Renderer ������Ʈ�� ������ ����

    void Start()
    {
        Time.timeScale = 1; // ���� ���� �� �ð� ������ 1�� �����Ͽ� ���� �ӵ��� �����ϵ��� ��
        playerRenderer = GetComponent<Renderer>(); // �÷��̾� ������Ʈ�� Renderer ������Ʈ�� �����ͼ� playerRenderer ������ ����
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �浹�� ������Ʈ�� �̸��� targetObjectName�� ������ Ȯ��
        if (collision.gameObject.name == targetObjectName)
        {
            Time.timeScale = 0; // �浹�� ������Ʈ�� �̸��� targetObjectName�� ���ٸ� �ð� ������ 0���� �����Ͽ� ������ �����Ŵ
        }
    }

    void OnBecameInvisible()
    {
        // �÷��̾ ī�޶� �信�� ��������� Ȯ��
        if (playerRenderer.isVisible == false)
        {
            Time.timeScale = 0; // �÷��̾ ī�޶� �信�� ������ٸ� �ð� ������ 0���� �����Ͽ� ������ �����Ŵ
        }
    }
}