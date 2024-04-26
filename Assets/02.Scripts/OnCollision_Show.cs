using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class OnCollision_Show : MonoBehaviour

{

    // 충돌할 대상 오브젝트의 이름을 저장하는 변수입니다.

    public string targetObjectName;

    // 충돌 시 활성화할 오브젝트의 이름을 저장하는 변수입니다.

    public string showObjectName;

    private Renderer PlayerOut;

    // 실제로 활성화할 오브젝트를 참조할 GameObject 변수입니다.

    GameObject showObject;

    // 게임 오브젝트가 시작될 때 한 번 호출됩니다.

    void Start()

    {

        // showObjectName에 해당하는 오브젝트를 찾아서 showObject에 할당합니다.

        showObject = GameObject.Find(showObjectName);

        // 게임이 시작될 때 showObject를 비활성화합니다.

        showObject.SetActive(false);

    }

    // 충돌이 감지되었을 때 호출됩니다.

    void OnCollisionEnter2D(Collision2D collision)

    {

        // 충돌한 오브젝트의 이름이 targetObjectName과 같은지 확인합니다.

        if (collision.gameObject.name == targetObjectName)

        {

            // 충돌한 오브젝트의 이름이 targetObjectName과 같다면

            // showObject를 활성화합니다.

            showObject.SetActive(true);

        }

    }

}