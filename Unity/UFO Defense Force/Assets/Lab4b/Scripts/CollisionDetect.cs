using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public GameManager gameManager;
    public ScoreManager scoreManager; //Store reference to score manager.
    
    public int scoreToGive;
    
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager game object and reference ScoreManager script component.
    }

    void OnTriggerEnter(Collider other) //Once the Trigger has been entered record collision in the argument variable "other"
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.isGameOver = true;
            Destroy(other.gameObject);
        }
        else
        {
            scoreManager.IncreaseScore(scoreToGive);// Increase the score.
            Destroy(gameObject);//Destroys this game object.
            Destroy(other.gameObject);//Destroys the other game object it hits.
        }
    }
}
