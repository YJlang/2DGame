using UnityEngine;
using System.Collections;

public class SpeedUpItem : MonoBehaviour
{
    public float speedUpDuration = 10f; // �ӵ� ���� ���� �ð� (��)
    public float speedUpFactor = 2f; // �ӵ� ���� ����

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(SpeedUpEffect());
            gameObject.SetActive(false); // ������ ������Ʈ ��Ȱ��ȭ
        }
    }

    private IEnumerator SpeedUpEffect()
    {
        Time.timeScale = speedUpFactor; // ���� �ӵ� ����

        yield return new WaitForSecondsRealtime(speedUpDuration); // ���� �ð� �������� ���� �ð� ���� ���

        Time.timeScale = 1f; // ���� �ӵ� ���󺹱�

        gameObject.SetActive(true); // ������ ������Ʈ Ȱ��ȭ
    }
}