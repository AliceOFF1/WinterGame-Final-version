using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMapSecond : MonoBehaviour
{

    public GameObject Map_2;
    bool Map_2Activate;

    void Start()
    {
        Map_2.SetActive(false);
        Map_2Activate = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))

        {
            Map_2Activate = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))

        {
            Map_2Activate = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Map_2Activate == true && Input.GetKey(KeyCode.E))
        {
            Map_2.SetActive(true);
        }

        if (Map_2Activate == true && Input.GetKey(KeyCode.X))
        {
            Map_2.SetActive(false);
        }

        if (Map_2Activate == false && Input.GetKey(KeyCode.X))
        {
            Map_2.SetActive(false);
        }
    }
}
