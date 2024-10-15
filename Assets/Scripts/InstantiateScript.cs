using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateScript : MonoBehaviour
{
    public Rigidbody spherePrefab; 
    public Transform placetoStart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
{
if(Input.GetButtonDown("Fire2"))
{
    Rigidbody newInstance;
    newInstance = Instantiate (spherePrefab, placetoStart.position, placetoStart.rotation);
    newInstance.AddForce(placetoStart.forward * 50); }
}
}
