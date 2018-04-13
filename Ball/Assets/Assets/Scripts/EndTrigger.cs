using System;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public Game_Manager gameManager;
    public float restartDelay = 3f;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        Debug.Log("Game Won!");
        FindObjectOfType<Game_Manager>().EndGame();
    }
}