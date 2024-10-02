using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text startText;
    public TMP_Text winnerText;
    private bool gameStarted = false;
    public BallMove ballMove;
    public PaddleMove leftPaddle;
    public PaddleMove rightPaddle;

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
    }

    void Update()
    {
        // Check if the player presses the "Space" key to start the game
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            gameStarted = true;
            startText.gameObject.SetActive(false);
            winnerText.gameObject.SetActive(false);
            Time.timeScale = 1f;
            leftPaddle.ResetPosition();
            rightPaddle.ResetPosition();
            ballMove.startGame();
        }
    }

    public void EndGame(string winner)
    {
        gameStarted = false;
        Time.timeScale = 0f;

        // Show the winner message
        winnerText.text = winner + "\nWIN";
        winnerText.gameObject.SetActive(true);
        startText.gameObject.SetActive(true);
    }
}
