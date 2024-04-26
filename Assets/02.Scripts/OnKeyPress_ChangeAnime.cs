using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_ChangeAnime : MonoBehaviour
{
    public string upAnime = "";
    public string downAnime = "";
    public string rightAnime = "";
    public string leftAnime = "";

    private string nowMode = "";
    private string oldMode = "";

    void Start()
    {
        nowMode = downAnime;
        oldMode = "";
    }

    void Update()
    {
        if (Input.GetKey("up")) { nowMode = upAnime; }
        if (Input.GetKey("down")) { nowMode = downAnime; }
        if (Input.GetKey("right")) { nowMode = rightAnime; }
        if (Input.GetKey("left")) { nowMode = leftAnime; }
    }

    void FixedUpdate()
    {
        if (nowMode != oldMode) //나우모드가 올드모드랑 같지않다면
        {
            oldMode = nowMode;
            Animator animator = this.GetComponent<Animator>();
            animator.Play(nowMode);
        }
    }

}