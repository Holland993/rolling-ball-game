using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnType = null;
    public float scaleMin = 0.2f;
    public float scaleMax = 2.0f;
    public float y_force = 100.0f;

    void Spawn()
    {
        GameObject obj = Instantiate(spawnType) as GameObject;
        
        obj.transform.position = this.transform.position;

        obj.AddComponent<Rigidbody>();

        obj.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * y_force);

        float scaleSize = Random.Range ( scaleMin, scaleMax );

        obj.transform.localScale = Vector3.one * scaleSize;

        Debug.Log(scaleSize);

        obj.name = "Doom";
    }

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            Spawn();
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            Spawn();
        }
    }
}
