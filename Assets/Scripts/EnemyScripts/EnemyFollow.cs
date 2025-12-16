using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyFollow : MonoBehaviour
{
    //public float speed;
    private Rigidbody2D rb;
    private Transform player;
    private bool isChasing;
    private float currentSpeed;
    [SerializeField] private float minSpeed = 5.5f;
    [SerializeField] private float maxSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        currentSpeed = Random.Range(minSpeed, maxSpeed);
    }

    void Update()
    {
        if(isChasing == true)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            rb.linearVelocity = direction * currentSpeed;
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
