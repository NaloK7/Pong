using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class BallMove : MonoBehaviour
{
    public float InitForce;
    public float MoveSpeed;
    float random;
    private bool isGameOver = false;
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        if (isGameOver && Input.GetKeyDown(KeyCode.Space))
        {

            startGame();
            GetComponent<Rigidbody2D>().AddForce(GetRandomDirection() * InitForce * 0.8f);
        }

    }

    
    void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.Space))
        {
            startGame();
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("LeftWall"))
        {
            isGameOver = true;
            gameManager.EndGame("Player 2");
        }
        else if (other.gameObject.CompareTag("RightWall"))
        {
            isGameOver = true;
            gameManager.EndGame("Player 1");
        }

    }
    Vector2 GetRandomDirection()
    {
        float x = Random.Range(0.5f, 1.0f) * (Random.value > 0.5f ? 1 : -1);
        float y = Random.Range(0.5f, 1.0f) * (Random.value > 0.5f ? 1 : -1); 
        return new Vector2(x, y).normalized;
    }

    private void startGame()
    {
        isGameOver = false;
        Time.timeScale = 1;

        // Replace the ball in center
        transform.position = Vector2.zero;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().AddForce(GetRandomDirection() * InitForce * 0.8f);
    }

}
