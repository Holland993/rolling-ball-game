using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaling : MonoBehaviour
{
    public float ScaleAmount = 3.0f;
    public Vector3 originalScale = Vector3.zero;

    public void EnableScale ()
    {
        this.transform.localScale = Vector3.one * ScaleAmount;
    }

    public void DisableScale ()
    {
        this.transform.localScale = originalScale;
    }
    
    void Awake ()
    {
        originalScale = this.transform.localScale;
    }

    void Update ()
    {
        if (Input.GetKeyDown (KeyCode.G))
        {
            EnableScale();
        }

        else if (Input.GetKeyUp(KeyCode.G))
        {
            DisableScale();
        }
    }
}
