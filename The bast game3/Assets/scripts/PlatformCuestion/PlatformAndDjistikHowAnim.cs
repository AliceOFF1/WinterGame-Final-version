using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAndDjistikHowAnim : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    private float timer;



    private void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
    }



    private void OnTriggerEnter2D(Collider2D collider)

    {
        if (collider.GetComponent<PlayerController>() != null)
        //Player entered collider! 
        {
            door.CloseDoor();
        }

    }

    private void OnTriggerStay2D(Collider2D collider)

    {
        if (collider.GetComponent<PlayerController>() != null)
        //Player entered collider! 
        {
            door.CloseDoor();
        }

    }

    private void OnTriggerExit2D(Collider2D collider)

    {
        if (collider.GetComponent<PlayerController>() != null)
        //Player entered collider! 
        {
            timer = 12f;
        }

    }

    void Update()
    {
        if (timer > 0)
        {
            door.OpenDoor();
            timer -= Time.deltaTime;
        }

        if (timer <= 0f)
        {
            door.CloseDoor();
        }
    }

}
