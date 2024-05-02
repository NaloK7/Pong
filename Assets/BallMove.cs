using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallMove : MonoBehaviour
{
    public float InitForce;
    public float MoveSpeed;
    float random;
    public TMP_Text endGameMessage;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("StartGame", 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void StartGame() {
        GetComponent<Rigidbody2D>().AddForce(GetRandomDirection() * InitForce);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("LeftWall"))
        {

            endGameMessage.text = "Player 2\nWIN\n'R' To restart" ;
            Time.timeScale = 0;

        }
        if (other.gameObject.CompareTag("RightWall"))
        {
            endGameMessage.text = "Player 1\nWIN\n'R' To restart";
            Time.timeScale = 0;

        }
    }

    Vector2 GetRandomDirection()
    {
        float x = Random.Range(-1.0f, 1.0f);
        float y = Random.Range(-1.0f, 1.0f);
        return new Vector2(x, y);
    }


}
