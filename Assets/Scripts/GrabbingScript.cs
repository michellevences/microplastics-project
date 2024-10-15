using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbingScript : MonoBehaviour
{

    private bool isGrabbing = false;
    private GameObject grabbedObject;
    private Rigidbody grabbedRigidbody;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isGrabbing)
        {
            // Raycast from the camera to detect grabbable objects.
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                // Check if the hit object is grabbable (you can add a specific tag or layer to define grabbable objects).
                if (hit.collider.CompareTag("Grabbable"))
                {
                    // Store the grabbed object and its Rigidbody.
                    grabbedObject = hit.collider.gameObject;
                    grabbedRigidbody = grabbedObject.GetComponent<Rigidbody>();

                    // Make the object kinematic while grabbing to prevent physics issues.
                    grabbedRigidbody.isKinematic = true;

                    // Set the flag to indicate grabbing.
                    isGrabbing = true;
                }
            }
        }

        if (Input.GetMouseButtonUp(0) && isGrabbing)
        {
            // Release the object.
            grabbedRigidbody.isKinematic = false;
            grabbedObject = null;
            isGrabbing = false;
        }

        if (isGrabbing && grabbedObject != null)
        {
            // Move the grabbed object to the desired position (e.g., the cursor's position).
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
            grabbedRigidbody.MovePosition(mousePosition);
        }
    }
}
