using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateIseMan : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject IseSmoke;
    public float timer;
    private bool Activate;


    void Start()
    {
        IseSmoke.SetActive(true);
        Activate = false;
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))

        {
            timer = 3f;
            Activate = true;

        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))

        {
            timer = 0f;
            Activate = false;

        }

    }



    void CreateMan()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }

    private void Update()
    {
        if (timer > 0 && Activate == true)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                CreateMan();
            }
        }
    }

}

