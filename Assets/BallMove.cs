using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class BallMove : MonoBehaviour
{
    public float InitForce;
    public float MoveSpeed;
    float random;
    public TMP_Text endGameMessage;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(1, 5);
        if (random == 1)
        {
            GetComponent<Rigidbody2D>().AddForce((Vector2.up + Vector2.right) * InitForce);
        }
        if (random == 2)
        {
            GetComponent<Rigidbody2D>().AddForce((Vector2.up + Vector2.left) * InitForce);
        }
        if (random == 3)
        {
            GetComponent<Rigidbody2D>().AddForce((Vector2.down + Vector2.right) * InitForce);

        }
        if (random == 4)
        {
            GetComponent<Rigidbody2D>().AddForce((Vector2.down + Vector2.left) * InitForce);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("LeftWall"))
        {
            endGameMessage.text = "Player 2\nWIN";
            Time.timeScale = 0;
        }
        if (other.gameObject.CompareTag("RightWall"))
        {
            endGameMessage.text = "Player 1\nWIN";
            Time.timeScale = 0;
        }
    }

}
