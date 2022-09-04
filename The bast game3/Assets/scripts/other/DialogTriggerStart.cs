using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriggerStart : MonoBehaviour
{
    private bool See = false;
    public GameObject DialogTriggerBox;
    public float sec = 1f;
    public GameObject DialogWithoutKey;



    void Start()
    {
        DialogTriggerBox.SetActive(false);
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))

        {
            See = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))

        {
            See = false;
        }
    }


    void OnTriggerStay2D(Collider2D other)
    {
        AntennaAndKey controller = other.GetComponent<AntennaAndKey>();

        if (controller != null)

        {
            Destroy(DialogWithoutKey);
        }

    }






    void Update()
    {
        if (See == true && Input.GetKey(KeyCode.E))
        {
            DialogTriggerBox.SetActive(true);
        }

        if (Input.GetKey(KeyCode.X))
        {
            DialogTriggerBox.SetActive(false);
        }

    }
}




