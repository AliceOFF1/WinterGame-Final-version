using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainTriggerForStart : MonoBehaviour
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
        if (coll.gameObject.tag == "Weapon")
        {
            door.OpenDoor();
        }

    }

    private void OnTriggerStay2D(Collider2D collider)
    {

        if (collider.GetComponent<WoodController>() != null)
        {
            // Player still on top of collider! 
            timer = 0.1f;
        }
    }


}
