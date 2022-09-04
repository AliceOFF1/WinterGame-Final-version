using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractedButton : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private IDoorToo door;

    private void Awake()
    {
        door = doorGameObject.GetComponent<IDoorToo>();
    }




    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerController>() != null && Input.GetKeyDown(KeyCode.E))
        {
            //Player entered collider! 
            door.OpenDoorToo();
        }
    }
}







