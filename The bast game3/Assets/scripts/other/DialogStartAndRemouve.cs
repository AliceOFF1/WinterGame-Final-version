using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogStartAndRemouve : MonoBehaviour
{
    private bool See = false;
    public GameObject DialogTriggerBox;
    public float sec = 1f;
    public GameObject dialog;
    public GameObject E;


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






    void Update()
    {
        if (See == true && Input.GetKey(KeyCode.E))
        {
            DialogTriggerBox.SetActive(true);
        }

        if (See == true && Input.GetKey(KeyCode.X))
        {
            DialogTriggerBox.SetActive(false);
            Destroy(dialog);
            Destroy(E);
        }

    }
}
