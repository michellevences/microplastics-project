using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceScript : MonoBehaviour {

    void Update () {

        if (Input.GetKey("up"))
        {
            Debug.Log("up arrow key is held down"); }
        if (Input.GetKey("down"))
        {
            Debug.Log("down arrow key is held down"); }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
        GetComponent<Rigidbody>().AddForce(transform.forward * 200f);
        GetComponent<Rigidbody>().useGravity = true; }
}
}