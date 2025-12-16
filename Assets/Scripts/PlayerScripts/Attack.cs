using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;
    public Transform spawnpoint, backPoint;
    private SpriteRenderer spriteRenderer;

    //makes a projectile appear infront of the player but not move
    public void AttackForward()
    {
        //clone projectile
        GameObject clonedProjectile;
        clonedProjectile = Instantiate(projectilePrefab, spawnpoint.position, new Quaternion(0, 0, 0, 0), null);
        //clonedProjectile.transform.position = spawnpoint.position;
        //fire it in direction
        Rigidbody2D projectileRigidbody;
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();
        projectileRigidbody.linearVelocity = projectileVelocity;
    }

    //makes a projectile appear behind the player but not move
    public void AttackBehind()
    {
        //clone projectile
        GameObject clonedProjectile;
        clonedProjectile = Instantiate(projectilePrefab, backPoint.position, new Quaternion(0, 0, 0, 0), null);
        //clonedProjectile.transform.position = Backpoint.position;
        //fire it in direction
        Rigidbody2D projectileRigidbody;
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();
        projectileRigidbody.linearVelocity = projectileVelocity;

    }
  
}
