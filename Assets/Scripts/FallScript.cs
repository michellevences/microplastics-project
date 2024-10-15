using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float fallSpeed = 2.0f; // Adjust this value to control the speed of falling.
    public float fallDistance = 10.0f; // Adjust this value to set the fall distance.

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // Calculate the downward movement.
        Vector3 newPosition = transform.position;
        newPosition.y -= fallSpeed * Time.deltaTime;

        // Check if the object has reached the desired fall distance.
        if (transform.position.y > initialPosition.y - fallDistance)
        {
            // Apply the falling effect to the object's position.
            transform.position = newPosition;
        }
        else
        {
            // Once it reaches the desired fall distance, you can reset the object's position or perform other actions.
            // For example, you can destroy the object or disable the script.
            // Uncomment and use one of the following lines based on your needs.

            // Destroy the object:
            // Destroy(gameObject);

            // Disable the script to stop further falling:
            // enabled = false;
        }
    }
}
