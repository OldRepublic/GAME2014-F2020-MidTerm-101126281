/*********************************************
NAME: Elijah Tong
Student Number: 101126281
Source File:BackgroundController.cs
Last Modified: 2020-10-21
Description: This creates a horizontally scrolling background that resets to it's original positions once it reaches a specific x position
Previous Version: This used to scroll vertically and reset at a specific y position
*********************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float HorizontalSpeed;
    public float HorizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        //return background positions to start positions so that it may loop scroll again
        transform.position = new Vector3(HorizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        //moves the background so that it will look like it is scrolling in game
        transform.position -= new Vector3(HorizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -HorizontalBoundary)
        {
            _Reset();
        }
    }
}
