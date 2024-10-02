using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text startText;
    public TMP_Text winnerText;
    public TMP_Text leftTouch;
    public TMP_Text rightTouch;
    public GameObject ball;
    public BallMove ballMove;
    public PaddleMove leftPaddle;
    public PaddleMove rightPaddle;
    private bool gameStarted = false;

    void Awake()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 60;
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        // Freeze the game at the beginning
        Time.timeScale = 0f;
        startText.gameObject.SetActive(true);
        winnerText.gameObject.SetActive(false);
        ball.SetActive(false);
    }

    void Update()
    {
        // Check if the player presses the "Space" key to start the game
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            gameStarted = true;
            startText.gameObject.SetActive(false);
            winnerText.gameObject.SetActive(false);
            leftTouch.text = "0";
            rightTouch.text = "0";
            Time.timeScale = 1f;
            leftPaddle.ResetPosition();
            rightPaddle.ResetPosition();
            ball.SetActive(true);
            ballMove.startGame();
        }
    }

    public void EndGame(string winner)
    {
        gameStarted = false;
        Time.timeScale = 0f;
        winnerText.text = winner + "\nWIN";
        winnerText.gameObject.SetActive(true);
        startText.gameObject.SetActive(true);
    }
    public void AddTouch(string player)
    {
        if (player == "1")
        {
            int touch = Int32.Parse(leftTouch.text) + 1;
            leftTouch.text = (touch).ToString();
        }
        else if (player == "2")
        {
            int touch = Int32.Parse(rightTouch.text) + 1;
            rightTouch.text = (touch).ToString();
        }
    }
}
