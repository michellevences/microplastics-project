using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public AudioClip mySound; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) {
            GetComponent<Renderer> ().material.color = Color.cyan;
            GetComponent<AudioSource>().PlayOneShot(mySound);
        }
        if (Input.GetKeyDown(KeyCode.M)) {
            GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (Input.GetKeyDown(KeyCode.Y)) {
            GetComponent<Renderer>().material.color = Color.yellow;
        } 
    }
}
