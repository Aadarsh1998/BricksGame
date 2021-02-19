using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCollision : MonoBehaviour
{
    Rigidbody2D rb;
    public float ballVelocity;
    public Transform paddle;
    public float offset;
    bool start = false;
    public float count = 8;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paddle")
        {
            //rb.velocity = new Vector2(0,10)*ballVelocity;
            print("Paddle collision");
        }
        else if (collision.gameObject.tag == "Boundary")
        {
            //rb.velocity = Vector2.up;
            //rb.velocity = new Vector2(0, 10) * ballVelocity;
            print("Boundary collision");
        }
        else if(collision.gameObject.tag == "Brick")
            {
            Destroy(collision.gameObject);
            count--;
        }
        if(count<=0)
        {
            print("Game over");
            SceneManager.LoadScene(1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(1);
            print("Ball destroyed");
        }
    }

    void Update()
    {
        //transform.position = new Vector2(paddle.position.x, paddle.position.y + offset);
        if (Input.GetMouseButtonDown(0) && start == false)
        {
            rb.velocity = new Vector2(0, ballVelocity);
            start = true;
            print("Ball launched");
        }
        if (start == false)
        {
            transform.position = new Vector2(paddle.position.x, paddle.position.y + offset);
        }
    }
}
