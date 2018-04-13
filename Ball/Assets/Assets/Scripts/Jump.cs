using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jump = 250f;
   
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jump, 0));
        }
    }
}
