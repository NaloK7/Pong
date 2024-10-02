using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public float PaddleSpeed;
    public KeyCode UpKey;
    public KeyCode DownKey;

    private Rigidbody2D rb;

    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Mouvement de la raquette
        if (Input.GetKey(UpKey))  // touche pour monter
        {
            rb.AddForce(Vector2.up * PaddleSpeed);
        }
        if (Input.GetKey(DownKey))  // touche pour descendre
        {
            rb.AddForce(Vector2.down * PaddleSpeed);
        }
    }
}
