using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;
    private int waypointIndex = 0; //number of current waypoint the player ocupies

    private bool movePossible = false;

    private void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position; //player in first waypoint
    }

    private void Update()
    {
        if(movePossible)  //move if it house is empty
        {
            MovePiece();
        }
    }

    private void MovePiece()
    {
        if(waypointIndex <= waypoints.Length -1)
        {
            transform.position = Vector2.MoveTowards(transform.position, 
                waypoints[waypointIndex].transform.position, 
                moveSpeed * Time.deltaTime);

            if(transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }
}
