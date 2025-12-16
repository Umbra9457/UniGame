using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MapTransition : MonoBehaviour
{

    [SerializeField] PolygonCollider2D mapBoundry;
    [SerializeField] Direction direction;
    [SerializeField] Transform teleportTargetPosition;



    enum Direction { up, down, left, right, teleport }

    

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

        switch (direction)
        {
            case Direction.up:
                additivePos.y += 2;
                break;
            case Direction.down:
                additivePos.y += -2;
                break;
            case Direction.left:
                additivePos.x += -2;
                break;
            case Direction.right:
                additivePos.x += 2;
                break;
        }

        Player.transform.position = additivePos;
    }
}
