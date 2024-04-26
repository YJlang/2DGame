using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_StopGame : MonoBehaviour
{
    #region 기존코드
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
    public string targetObjectName; // 충돌 시 게임을 종료시킬 대상 오브젝트의 이름
    private Renderer playerRenderer; // 플레이어의 Renderer 컴포넌트를 저장할 변수

    void Start()
    {
        Time.timeScale = 1; // 게임 시작 시 시간 배율을 1로 설정하여 정상 속도로 동작하도록 함
        playerRenderer = GetComponent<Renderer>(); // 플레이어 오브젝트의 Renderer 컴포넌트를 가져와서 playerRenderer 변수에 저장
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌한 오브젝트의 이름이 targetObjectName과 같은지 확인
        if (collision.gameObject.name == targetObjectName)
        {
            Time.timeScale = 0; // 충돌한 오브젝트의 이름이 targetObjectName과 같다면 시간 배율을 0으로 설정하여 게임을 종료시킴
        }
    }

    void OnBecameInvisible()
    {
        // 플레이어가 카메라 뷰에서 사라졌는지 확인
        if (playerRenderer.isVisible == false)
        {
            Time.timeScale = 0; // 플레이어가 카메라 뷰에서 사라졌다면 시간 배율을 0으로 설정하여 게임을 종료시킴
        }
    }
}