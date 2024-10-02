using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class BallMove : MonoBehaviour
{
    public float InitForce;
    public float MoveSpeed;
    public GameManager gameManager;

    void Start()
    {
        

    }

    
    void Update()
    {
 
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

}
