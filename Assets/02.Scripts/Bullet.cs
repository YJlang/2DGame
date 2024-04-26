using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 발사할 총알 오브젝트를 저장할 변수
    public GameObject BulletObject;
    // 총알의 Rigidbody2D 컴포넌트를 저장할 변수
    private Rigidbody2D rbody;
    // 총알의 발사 속도를 지정할 변수
    public float launchSpeed = 10.0f;

    // 가장 가까운 타겟 오브젝트를 저장할 변수
    private GameObject targetObject;

    void Update()
    {
        // 매 프레임마다 실행되는 Update 함수
        // 'Z' 키를 눌렀을 때 총알 발사
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // 가장 가까운 타겟 오브젝트 찾기
            targetObject = FindNearestTargetObject();

            // 타겟 오브젝트가 존재하는 경우
            if (targetObject != null)
            {
                // 총알 오브젝트 생성 (BulletObject 프리팹 사용)
                GameObject missile = Instantiate(BulletObject, transform.position, Quaternion.identity);
                // 생성된 총알 오브젝트의 Rigidbody2D 컴포넌트 가져오기
                rbody = missile.GetComponent<Rigidbody2D>();

                // 총알이 타겟 오브젝트를 향하는 방향 계산
                Vector2 direction = (targetObject.transform.position - transform.position).normalized;
                // 계산된 방향으로 총알에 힘을 가하여 발사
                rbody.AddForce(direction * launchSpeed, ForceMode2D.Impulse);
            }
        }
    }

    // 가장 가까운 타겟 오브젝트를 찾는 함수
    private GameObject FindNearestTargetObject()
    {
        // "Respawn" 태그를 가진 모든 오브젝트 찾기
        GameObject[] targetObjects = GameObject.FindGameObjectsWithTag("Respawn");
        // 가장 가까운 타겟 오브젝트를 저장할 변수 초기화
        GameObject nearestTarget = null;
        // 가장 가까운 거리를 저장할 변수 초기화 (무한대로 설정)
        float nearestDistance = Mathf.Infinity;

        // 찾은 모든 타겟 오브젝트에 대해 반복
        foreach (GameObject target in targetObjects)
        {
            // 현재 오브젝트와 타겟 오브젝트 사이의 거리 계산
            float distance = Vector2.Distance(transform.position, target.transform.position);
            // 계산된 거리가 현재까지의 가장 가까운 거리보다 작은 경우
            if (distance < nearestDistance)
            {
                // 가장 가까운 거리 갱신
                nearestDistance = distance;
                // 가장 가까운 타겟 오브젝트 갱신
                nearestTarget = target;
            }
        }

        // 가장 가까운 타겟 오브젝트 반환
        return nearestTarget;
    }
}