using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatItem : MonoBehaviour
{

    private bool See = false;
    private bool ItemSee = false;
    public GameObject objectToSpawn;




    void Start()
    {
        objectToSpawn.SetActive(false);
    }



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
            objectToSpawn.SetActive(true);
        }

    }
}
