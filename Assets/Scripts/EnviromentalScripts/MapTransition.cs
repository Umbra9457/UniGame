using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MapTransition : MonoBehaviour
{
    // [1] Capitalized 'D' in Collider2D
    [SerializeField] PolygonCollider2D mapBoundry;
    [SerializeField] Direction direction;
    [SerializeField] Transform teleportTargetPosition;

    // [2] Declaration for the camera confiner component

    enum Direction { up, down, left, right, teleport }

    // Add a Start or Awake method to find the confiner component
    void Awake()
    {


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           

            UpdatePlayerPosition(collision.gameObject);

            //MapController_Manual.Instance?.HighlightArea(mapBoundry.name);
            //MapController_Dynamic.Instance?.UpdateCurrentArea(mapBoundry.name);
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
