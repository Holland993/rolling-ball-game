using UnityEngine;

public class Collison : MonoBehaviour {

    public PlayerController movement;
    public Game_Manager gameManager;

    //This function runs when we hit another object
    // We get information about the collision and call it collisionInfo
    void OnCollisionEnter(Collision collisionInfo)
    {
        // we check if the object we collided with a tag called Obstical
        if (collisionInfo.collider.tag == "Obstical")
        {
            movement.enabled = false; // Disable player movement
            FindObjectOfType<Game_Manager>().EndGame();
        }
    }
}
