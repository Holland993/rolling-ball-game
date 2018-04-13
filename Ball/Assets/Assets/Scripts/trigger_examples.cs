using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_examples : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object: " + other.name + " entered trigger.");
    }
}
