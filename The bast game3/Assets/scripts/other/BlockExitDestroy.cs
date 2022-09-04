using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockExitDestroy : MonoBehaviour
{
    private bool See = false;
    public GameObject DialogTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))

        {
            See = true;
        }
    }



    void Update()
    {
        if (See == true && Input.GetKey(KeyCode.E))
        {
            Destroy(DialogTrigger);
        }

    }
}

