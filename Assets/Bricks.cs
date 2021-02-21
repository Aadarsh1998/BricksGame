using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bricks : MonoBehaviour
{
    SpriteRenderer sprite;
    public int health = 2;
    //public int count = 8;
    
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            health--;
            sprite.color = new Color(1, 0.4f, 0, 1);
        }
       
        if (health <= 0)
        {
            Destroy(gameObject);
        }
       
    }
    }

