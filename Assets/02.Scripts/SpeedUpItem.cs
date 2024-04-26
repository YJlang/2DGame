using UnityEngine;
using System.Collections;

public class SpeedUpItem : MonoBehaviour
{
    public float speedUpDuration = 10f; // 속도 증가 지속 시간 (초)
    public float speedUpFactor = 2f; // 속도 증가 배율

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(SpeedUpEffect());
            gameObject.SetActive(false); // 아이템 오브젝트 비활성화
        }
    }

    private IEnumerator SpeedUpEffect()
    {
        Time.timeScale = speedUpFactor; // 게임 속도 증가

        yield return new WaitForSecondsRealtime(speedUpDuration); // 실제 시간 기준으로 지속 시간 동안 대기

        Time.timeScale = 1f; // 게임 속도 원상복구

        gameObject.SetActive(true); // 아이템 오브젝트 활성화
    }
}