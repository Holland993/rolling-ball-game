using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColour : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

    void Start ()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            EnableColor();
        }

        else
        {
            DisableColor();
        }
    }
    
    public void EnableColor ()
    {
        rend.sharedMaterial = material[1];
    }

    public void DisableColor ()
    {
        rend.sharedMaterial = material[0];
    }
}
