using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_SwitchScene : MonoBehaviour
{
    public string targetObjectName;
    public string sceneName;

    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(sceneName); //EndScene
    }
}
