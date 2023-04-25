using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddleMove : MonoBehaviour
{
    public float BallForce;

    public float PaddleSpeed;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // LEFT PLAYER
        if (Input.GetKey(KeyCode.Z))  // up
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * PaddleSpeed);
        }
        if (Input.GetKey(KeyCode.S))  // down
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.down * PaddleSpeed);
        }
        
    }

}
