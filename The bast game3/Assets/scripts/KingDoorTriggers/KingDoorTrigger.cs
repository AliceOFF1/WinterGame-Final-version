using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingDoorTrigger : MonoBehaviour
{
    private bool ActivatorBox1 = false;
    private bool ActivatorBox2 = false;
    private bool ActivatorBox3 = false;
    private bool ActivatorLamp1 = false;
    private bool ActivatorLamp2 = false;
    private bool ActivatorLamp3 = false;
    public GameObject WoodBlade;
    public GameObject Danger;

    void Start()
    {
        WoodBlade.SetActive(false);
        Danger.SetActive(true);
    }



    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<BoxTrigger>() != null)
        {
            ActivatorBox1 = true;
        }

        if (collider.GetComponent<BoxTriggerSecond>() != null)
        {
            ActivatorBox2 = true;
        }

        if (collider.GetComponent<BoxTriggerThird>() != null)
        {
            ActivatorBox3 = true;
        }

        if (collider.GetComponent<LampTrigger>() != null)
        {
            ActivatorLamp1 = true;
        }

        if (collider.GetComponent<LampTriggerSecond>() != null)
        {
            ActivatorLamp2 = true;
        }

        if (collider.GetComponent<LampTriggerThird>() != null)
        {
            ActivatorLamp3 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.GetComponent<BoxTrigger>() != null)
        {
            ActivatorBox1 = false;
        }

        if (collider.GetComponent<BoxTriggerSecond>() != null)
        {
            ActivatorBox2 = false;
        }

        if (collider.GetComponent<BoxTriggerThird>() != null)
        {
            ActivatorBox3 = false;
        }

        if (collider.GetComponent<LampTrigger>() != null)
        {
            ActivatorLamp1 = false;
        }

        if (collider.GetComponent<LampTriggerSecond>() != null)
        {
            ActivatorLamp2 = false;
        }

        if (collider.GetComponent<LampTriggerThird>() != null)
        {
            ActivatorLamp3 = false;
        }
    }

    void Update()
    {
        if (ActivatorBox1 == true && ActivatorBox2 == true && ActivatorBox3 == true && ActivatorLamp1 == true && ActivatorLamp2 == true && ActivatorLamp3 == true)
        {
            WoodBlade.SetActive(true);
            Danger.SetActive(false);
        }

    }
}


