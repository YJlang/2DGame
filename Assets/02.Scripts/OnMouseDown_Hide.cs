using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDown_Hide : MonoBehaviour
{
    void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }

}
