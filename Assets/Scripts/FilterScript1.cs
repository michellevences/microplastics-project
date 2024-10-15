using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterScript1 : MonoBehaviour
{
    public GameObject fact;
    public AudioClip mySound;

    void Start()
    {
        fact.SetActive(false);
    }
    void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "filter")
        {
            GetComponent<AudioSource>().PlayOneShot(mySound);
            fact.SetActive(true);
            RenderSettings.skybox.SetFloat("_Exposure",
(RenderSettings.skybox.GetFloat("_Exposure") + 0.1f));
            Destroy(gameObject, 3f);
        }
    }
}