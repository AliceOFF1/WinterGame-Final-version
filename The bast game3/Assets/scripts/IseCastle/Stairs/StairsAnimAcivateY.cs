using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsAnimAcivateY : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    bool Activate = false;

    [SerializeField] private AudioSource Sound;



    private void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
    }



    private void OnTriggerEnter2D(Collider2D collider)

    {
        if (collider.GetComponent<PlayerController>() != null)
        //Player entered collider! 
        {
            Activate = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collider)

    {
        if (collider.GetComponent<PlayerController>() != null)
        //Player entered collider! 
        {
            Activate = false;
        }

    }





    void Update()
    {
        if (Activate && Input.GetKey(KeyCode.F))
        {
            door.OpenDoor();
            Sound.Play();

        }

        if (Activate && Input.GetKey(KeyCode.G))
        {
            door.CloseDoor();
            Sound.Play();
        }

    }

}

