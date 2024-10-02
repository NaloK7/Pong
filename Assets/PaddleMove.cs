using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public float PaddleSpeed;
    public KeyCode UpKey;
    public KeyCode DownKey;
    private Vector3 initialPosition;

    private Rigidbody2D rb;

    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
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

    public void ResetPosition()
    {
        // Remets la raquette à sa position initiale
        transform.position = initialPosition;
    }
}
