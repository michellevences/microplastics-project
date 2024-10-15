using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour

{
    public float moveSpeed = 2.0f;  // Adjust this value to control the speed of movement.
    public float leftBound = -5.0f; // Set the left boundary position.
    public float rightBound = 5.0f; // Set the right boundary position.
    private bool movingRight = true; // Initially, start moving to the right.

    void Update()
    {
        // Calculate the next position based on the direction and speed.
        Vector3 nextPosition = transform.position;

        if (movingRight)
        {
            nextPosition.x += moveSpeed * Time.deltaTime;
            if (nextPosition.x > rightBound)
            {
                nextPosition.x = rightBound;
                movingRight = false;
            }
        }
        else
        {
            nextPosition.x -= moveSpeed * Time.deltaTime;
            if (nextPosition.x < leftBound)
            {
                nextPosition.x = leftBound;
                movingRight = true;
            }
        }

        // Update the object's position.
        transform.position = nextPosition;
    }
}