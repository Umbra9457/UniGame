using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyFollow : MonoBehaviour
{
    private Rigidbody2D rb;
    // Serializing player might make it easier to link in the Inspector
    // instead of relying on FindWithTag at runtime.
    [SerializeField] private Transform player;
    private Vector2 startPosition;
    public float moveSpeed = 4f;
    private bool isChasing = false;

    // Define a stopping distance to prevent jittering around the start point
    private const float stopDistance = 0.1f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // If 'player' wasn't assigned in the Inspector, fall back to FindWithTag
        if (player == null)
        {
            GameObject playerObject = GameObject.FindWithTag("Player");
            if (playerObject != null)
            {
                player = playerObject.transform;
            }
            else
            {
                Debug.LogError("Player object with tag 'Player' not found!");
            }
        }

        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        Vector2 targetPosition;

        if (isChasing && player != null)
        {
            targetPosition = player.position;
        }
        else
        {
            targetPosition = startPosition;
        }

        // Calculate direction only if a move is needed
        if (Vector2.Distance(transform.position, targetPosition) > stopDistance)
        {
            Vector2 direction = (targetPosition - (Vector2)transform.position).normalized;
            rb.linearVelocity = direction * moveSpeed;
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
            // Ensure position snaps exactly to start position when idle/returning
            if (!isChasing)
            {
                transform.position = startPosition;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isChasing = true;
            if (rb != null)
            {
                rb.linearVelocity = Vector2.zero;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isChasing = false;
            if (rb != null)
            {
                rb.linearVelocity = Vector2.zero;
            }
        }
    }
}
