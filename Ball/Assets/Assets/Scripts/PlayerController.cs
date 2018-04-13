using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 600f;  // Variable that determines the forward force
    public float sidewaysForce = 500f;  // Variable that determines the sideways force
    public float jumpForce = 8000f;

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            // Add a forward force
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            // Add a forward force
            rb.AddForce(0, 0, - forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))  // If the player is pressing the "d" key
        {
            // Add a force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))  // If the player is pressing the "a" key
        {
            // Add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<Game_Manager>().EndGame();
        }
    }
}
