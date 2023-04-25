using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallMove : MonoBehaviour
{
    public float InitForce;
    public float MoveSpeed;
    public float random;
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

}
