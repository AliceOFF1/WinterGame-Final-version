using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerTriggerBoxForStart : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    private float timer;

    private void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                door.CloseDoor();
            }
        }
    }



    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "SnowBoll")
        {
            door.OpenDoor();
        }

        if (coll.gameObject.tag == "Weapon")
        {
            Destroy(gameObject, 0.3f);
        }

        if (coll.gameObject.tag == "Ground")
        {
            Destroy(gameObject, 0.3f);
        }

    }

    private void OnTriggerStay2D(Collider2D collider)
    {

        if (collider.GetComponent<WoodController>() != null)
        {
            // Player still on top of collider! 
            timer = 5f;
        }
    }


}