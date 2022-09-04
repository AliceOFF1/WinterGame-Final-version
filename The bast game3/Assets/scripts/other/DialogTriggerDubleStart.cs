using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriggerDubleStart : MonoBehaviour
{
    private bool See_2 = false;
    public float sec = 1f;
    public GameObject DialogTriggerKey;




    void Start()
    {
        DialogTriggerKey.SetActive(false);
    }




    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)

        {
            See_2 = true;
        }

    }




    void Update()
    {

        if (See_2 == true && Input.GetKey(KeyCode.E))
        {
            DialogTriggerKey.SetActive(true);
        }

        if (See_2 == true && Input.GetKey(KeyCode.X))
        {
            DialogTriggerKey.SetActive(false);
        }

    }

}
