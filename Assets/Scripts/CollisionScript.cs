using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public int counter = 0;
    public bool canChange = true;

    public AudioClip mySound;
    // public GameObject skybox;
    public GameObject fact;
    public GameObject greenfact;
    public int size;
    public AudioClip secondSound;


    void Start()
    {
        fact.SetActive(false);
        greenfact.SetActive(false);
        Debug.Log("Start enter");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("collide & play sound");
            GetComponent<AudioSource>().PlayOneShot(mySound);

            Debug.Log(size);

            fact.SetActive(true);
            greenfact.SetActive(false);

            Destroy(gameObject, 3f);

            // set it to true when the user collides with plastic
            // fact.SetActive(true);

        //if (canChange == true)

        //if (other.gameObject.tag == "filter")

        
            //gameObject.SetActive(false);
            RenderSettings.skybox.SetFloat("_Exposure",
            (RenderSettings.skybox.GetFloat("_Exposure") - 0.2f));
            counter++;

            
        }
        if (other.gameObject.tag == "filter") {

            gameObject.SetActive(false);
            RenderSettings.skybox.SetFloat("_Exposure",
            (RenderSettings.skybox.GetFloat("_Exposure") + 0.05f));
            counter++;

            greenfact.SetActive(true);
            fact.SetActive(false);
            GetComponent<AudioSource>().PlayOneShot(mySound);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (counter == 5)
        {
            canChange = false;
        }
    }
}