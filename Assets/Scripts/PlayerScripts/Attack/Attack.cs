using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Vector2 projectileVelocity;
    public Transform FrontPoint, BackPoint, BottomPoint, TopPoint;
    private SpriteRenderer spriteRenderer;

    private GameObject AttackActive;

    void Update()
    {
        if (AttackActive == null)
        {
            if (Input.GetKeyDown("right"))
            {
                AttackForward();
            }

            if (Input.GetKeyDown("left"))
            {
                AttackBehind();
            }

            if (Input.GetKeyDown("down"))
            {
                AttackBottom();
            }
            if (Input.GetKeyDown("up"))
            {
                AttackTop();
            }
        }
        
    }



    //makes a projectile appear infront of the player but not move
    public void AttackForward()
    {
        Quaternion targetRotation = Quaternion.Euler(0, 0, -90);
        //clone projectile
        AttackActive = Instantiate(projectilePrefab, FrontPoint.position, targetRotation, null);
        //clonedProjectile.transform.position = spawnpoint.position;
        //fire it in direction
        Rigidbody2D projectileRigidbody;
        projectileRigidbody = AttackActive.GetComponent<Rigidbody2D>();
        projectileRigidbody.linearVelocity = projectileVelocity;
    }

    //makes a projectile appear behind the player but not move
    public void AttackBehind()
    {
        Quaternion targetRotation = Quaternion.Euler(180, 0, 90);
        //clone projectile
        AttackActive = Instantiate(projectilePrefab, BackPoint.position, targetRotation, null);
        //clonedProjectile.transform.position = Backpoint.position;
        //fire it in direction
        Rigidbody2D projectileRigidbody;
        projectileRigidbody = AttackActive.GetComponent<Rigidbody2D>();
        projectileRigidbody.linearVelocity = projectileVelocity;

    }


    public void AttackBottom()
    {

        Quaternion targetRotation = Quaternion.Euler(0, 0, 180);
        //clone projectile
        AttackActive = Instantiate(projectilePrefab, BottomPoint.position, targetRotation, null);
        //clonedProjectile.transform.position = Backpoint.position;
        //fire it in direction
        Rigidbody2D projectileRigidbody;
        projectileRigidbody = AttackActive.GetComponent<Rigidbody2D>();
        projectileRigidbody.linearVelocity = projectileVelocity;

    }

    public void AttackTop()
    {
        Quaternion targetRotation = Quaternion.Euler(0, 0, 0);
        //clone projectile
        AttackActive = Instantiate(projectilePrefab, TopPoint.position, targetRotation, null);
        //clonedProjectile.transform.position = Backpoint.position;
        //fire it in direction
        Rigidbody2D projectileRigidbody;
        projectileRigidbody = AttackActive.GetComponent<Rigidbody2D>();
        projectileRigidbody.linearVelocity = projectileVelocity;

    }
}
