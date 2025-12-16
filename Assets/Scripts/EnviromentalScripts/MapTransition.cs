using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MapTransition : MonoBehaviour
{

    [SerializeField] PolygonCollider2D mapBoundry;
    [SerializeField] Direction direction;
    [SerializeField] Transform teleportTargetPosition;



    enum Direction {teleport}

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           

            UpdatePlayerPosition(collision.gameObject);

        }


    }

    void UpdatePlayerPosition(GameObject Player)
    {
        if (direction == Direction.teleport)
        {
            Player.transform.position = teleportTargetPosition.position;
            return;
        }

        Vector3 additivePos = Player.transform.position;

      
        Player.transform.position = additivePos;
    }
}
