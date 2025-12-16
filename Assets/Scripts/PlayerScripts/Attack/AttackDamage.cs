using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamage : MonoBehaviour
{

    public int weaponDamage = 10;


    //deals damage to enemies when the collid with the attack
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;
        EnemyHealth Enemy = collider.GetComponent<EnemyHealth>();
        if (Enemy)
        {
            Enemy.ChangeHealth(-weaponDamage);
        }


    }

}
