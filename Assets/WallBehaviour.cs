using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehaviour : MonoBehaviour
{
    public GameObject ball;
    public float BallForce;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //private void OnCollisionEnter2D(Collision2D other)
    //{
    //    if (other.gameObject.CompareTag("Ball"))
    //    {
    //        Vector2 entre = other.GetContact(0).normal;
    //        Debug.Log(Vector2.Reflect(other.gameObject.GetComponent<Rigidbody2D>().velocity, other.contacts[0].normal));
    //        other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.Reflect(this.GetComponent<Rigidbody2D>().velocity, other.contacts[0].normal));

    //    }
    //}
}
