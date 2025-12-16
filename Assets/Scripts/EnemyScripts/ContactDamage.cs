using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamage : MonoBehaviour
{

    public int hazardDamage = 10; //sets damage delt by enemies

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider; //checks for collision between enemy and player
        PlayerHealth Player = collider.GetComponent<PlayerHealth>();
        if (Player)
        {
            Player.ChangeHealth(-hazardDamage); //takes damage from players current health
        }


    }
   

}