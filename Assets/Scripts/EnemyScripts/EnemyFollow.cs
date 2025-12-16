using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyFollow : MonoBehaviour
{
   //set up variables
    private Rigidbody2D rb;
    private Transform player;
    private bool isChasing;
    private float currentSpeed;
    private float minSpeed = 8f;
    private float maxSpeed = 14f;
    private SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        currentSpeed = Random.Range(minSpeed, maxSpeed);
      
    }

    void Update()
    {

        Vector3 pos = transform.position;



        if (isChasing == true)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            rb.linearVelocity = direction * currentSpeed;
            if (sr != null)
            {
                
                if (direction.x > 0)
                {
                    sr.flipX = true;
                }
                else if (direction.x < 0)
                {
                    sr.flipX = false;
                }
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {   
            if (player == null)
            {
                player = collision.transform;
            }
            
            isChasing = true;
            AudioManager.Instance.Play(AudioManager.SoundType.GhostSpot);
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb.linearVelocity = Vector2.zero;
            isChasing = false;
        }
    }
}
