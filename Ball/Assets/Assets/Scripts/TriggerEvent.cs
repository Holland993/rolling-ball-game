using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public GameObject lightBulb = null;
    public GameObject box = null;
    public AudioClip beep = null;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            lightBulb.SetActive(true);

            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            box.GetComponent<ObjectScaling>().EnableScale();
            box.GetComponent<ObjectColour>().EnableColor();
        }
    }

    void OnTriggerExit (Collider other)
    {
        if ( other.tag == "Player")
        {
            lightBulb.SetActive (false);

            box.GetComponent<ObjectScaling>().DisableScale();
            box.GetComponent<ObjectColour>().DisableColor();
        }
    }
}
