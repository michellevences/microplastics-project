using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movements2 : MonoBehaviour
{
    public float moveSpeed = 2.0f;  // Adjust this value to control the speed of movement.
    public float frontBound = 5.0f; // Set the front boundary position.
    public float backBound = -5.0f; // Set the back boundary position.
    private bool movingForward = true; // Initially, start moving forward.

    void Update()
    {
        // Calculate the next position based on the direction and speed.
        Vector3 nextPosition = transform.position;

        if (movingForward)
        {
            nextPosition.z += moveSpeed * Time.deltaTime;
            if (nextPosition.z > frontBound)
            {
                nextPosition.z = frontBound;
                movingForward = false;
            }
        }
        else
        {
            nextPosition.z -= moveSpeed * Time.deltaTime;
            if (nextPosition.z < backBound)
            {
                nextPosition.z = backBound;
                movingForward = true;
            }
        }

        // Update the object's position.
        transform.position = nextPosition;
    }
}