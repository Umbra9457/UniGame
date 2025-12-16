using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WalkScript : MonoBehaviour
{
    public float speed = 0.2f;
    private SpriteRenderer sr;

    void Start()
    {
   
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
       
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
            sr.flipX = false;

        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
            sr.flipX = true;

        }

        transform.position = pos;

    }
}
