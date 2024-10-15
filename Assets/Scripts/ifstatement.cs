using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifstatement : MonoBehaviour { void Update() {
if (Input.GetKeyDown(KeyCode.C))
{
GetComponent<Renderer>().material.color=new Color(0.0f, 0.5f, 0.2f, 0.9f);
}
if (Input.GetKeyDown(KeyCode.M)) {
GetComponent<Renderer>().material.color = Color.magenta;
}
if (Input.GetKeyDown(KeyCode.Y)) {
} 
}}