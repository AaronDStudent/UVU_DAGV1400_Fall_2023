using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;
    private SoundManager soundManager;
    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }
    
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            EndGame();// Start EndGame method.
        }
        else
        {
            gameOverText.gameObject.SetActive(false);// Keep UI text Game Over hidden.
        }
    }

    public void EndGame()
    {
        soundManager.PlaySFX(soundManager.gameOverSound);
        gameOverText.gameObject.SetActive(true);//Make Game Over text appear.
        Time.timeScale = 0; // Freeze time.
    }
}
