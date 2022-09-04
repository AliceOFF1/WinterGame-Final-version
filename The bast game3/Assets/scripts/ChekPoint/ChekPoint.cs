using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekPoint : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    bool Activate = false;



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





    void Update()
    {
        if (Activate == true)
        {
            door.OpenDoor();
        }

        if (Activate == false)
        {
            door.CloseDoor();
        }

    }

}
