using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text startText;
    public TMP_Text winnerText;
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
        // Shows the start message
        startText.gameObject.SetActive(true);
        winnerText.gameObject.SetActive(false);
    }

    void Update()
    {
        // Check if the player presses the "Space" key to start the game
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    void StartGame()
    {
        gameStarted = true;
        //Time.timeScale = 1f;
        // Hide the start message
        startText.gameObject.SetActive(false);
    }
    public void EndGame(string winner)
    {
        gameStarted = false;
        Time.timeScale = 0f;

        // Show the winner message
        winnerText.text = winner + "\nWIN";
        winnerText.gameObject.SetActive(true);
    }
}
