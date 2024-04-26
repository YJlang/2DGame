// BulletCollision 스크립트
using UnityEngine;

public class BulletPower : MonoBehaviour
{
    //총알 회전 스피드
    public float speed = 1f;

    // 공격력을 나타내는 열거형
    public enum AttackPower
    {
        Normal,
        Super
    }

    // 현재 공격력 상태
    public AttackPower currentPower = AttackPower.Normal;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌한 오브젝트의 태그가 "Respawn"인 경우
        if (collision.gameObject.CompareTag("Respawn"))
        {
            // 충돌한 오브젝트의 RespawnObject 스크립트 가져오기
            Obake_HP respawnObject = collision.gameObject.GetComponent<Obake_HP>();

            // RespawnObject 스크립트가 존재하는 경우
            if (respawnObject != null)
            {
                // 현재 공격력에 따라 오브젝트 파괴 또는 체력 감소
                if (currentPower == AttackPower.Super)
                {
                    // Super 상태일 때는 한 번의 충돌로 오브젝트 파괴
                    respawnObject.DestroyObject();
                }
                else
                {
                    // Normal 상태일 때는 체력 감소
                    respawnObject.DecreaseHealth();
                }
            }

            // 총알 오브젝트 파괴
            Destroy(gameObject);
        }
    }


    void FixedUpdate()
    {
        this.transform.Rotate(0, 0, speed * 10f);
    }
}