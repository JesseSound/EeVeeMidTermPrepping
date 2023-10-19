using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class player : MonoBehaviour
{
    
    public float speed;
    Rigidbody2D rb;
    public int score = 0;
    public int lives = 3;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0.0f, speed);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, 0.0f);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0.0f, -speed);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, 0.0f);
        }

        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
