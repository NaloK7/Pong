using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallMove : MonoBehaviour
{
    public float InitForce;
    public float MoveSpeed;
    public float maxSpeed;
    public GameManager gameManager;

    void Start()
    {
        

    }

    
    void Update()
    {
        LimitBallSpeed();
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("LeftWall"))
        {
            
            gameManager.EndGame("Player 2");
        }
        else if (other.gameObject.CompareTag("RightWall"))
        {
            
            gameManager.EndGame("Player 1");
        }
        else if (other.gameObject.CompareTag("LeftPaddle"))
        {
            gameManager.AddTouch("1");
        }
        else if (other.gameObject.CompareTag("RightPaddle"))
        {
            gameManager.AddTouch("2");
        }
    }

    Vector2 GetRandomDirection()
    {
        float x = Random.Range(0.5f, 1.0f) * (Random.value > 0.5f ? 1 : -1);
        float y = Random.Range(0.5f, 1.0f) * (Random.value > 0.5f ? 1 : -1); 
        return new Vector2(x, y).normalized;
    }

    public void startGame()
    {
        transform.position = Vector2.zero;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().AddForce(GetRandomDirection() * InitForce * 0.8f);
    }
    private void LimitBallSpeed()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb.velocity.magnitude > maxSpeed) 
        {
            
            rb.velocity = rb.velocity.normalized * maxSpeed; 
        }
        //Debug.Log("Current Speed: " + rb.velocity.magnitude);
    }
}
