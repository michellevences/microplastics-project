using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject skybox;
    public Transform target = null;
    public Transform target2 = null;
    bool firstJump = false;
    bool secondJump = false;
    public GameObject filter;
    public GameObject welcome1;
    public GameObject welcome2;
    public GameObject fact1;
    public GameObject fact2;
    public GameObject fact3;
    public GameObject fact4;
    public GameObject fact5;


    void Start()
    {
        filter.SetActive(false);
        welcome1.SetActive(true);
        welcome2.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "firstLoc" && firstJump == false && secondJump == false)
        {
            // referring to object its attached to
            this.transform.position = target.position;
            firstJump = true;
        }

        if (other.gameObject.tag == "secLoc" && firstJump == false && secondJump == false)
        {
            secondJump = true;
            this.transform.position = target2.position;

            RenderSettings.skybox.SetFloat("_Exposure",
    (RenderSettings.skybox.GetFloat("_Exposure") - 1.0f));

            filter.SetActive(true);
            welcome1.SetActive(false);
            welcome2.SetActive(true);
            fact1.SetActive(false);
            fact2.SetActive(false);
            fact3.SetActive(false);
            fact4.SetActive(false);
            fact5.SetActive(false);



        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "firstLoc")
        {
            secondJump = false;
        }

        if (other.gameObject.tag == "secLoc")
        {
            firstJump = false;
        }
    }

}
