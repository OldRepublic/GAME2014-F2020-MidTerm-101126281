/*********************************************
NAME: Elijah Tong
Student Number: 101126281
Source File:EnemyController.cs
Last Modified: 2020-10-21
Description: Takes in vertical speed, boundary and direction. Then moves the enemy prefab in the positive or negative y direction depending on if the positive or negative boundary was touched by the enemy
Previous Version: Same as it is now but it moved horizontally on the x axis and had boundaries on the x axis instead.
*********************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float VerticalSpeed;
    public float VerticalBoundary;
    public float direction;
   

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        //Enemies move up or down depending on direction value
        transform.position += new Vector3(0.0f, VerticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= VerticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -VerticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
