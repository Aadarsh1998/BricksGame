using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    Rigidbody2D rb;
    public float ballVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Paddle")
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
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
