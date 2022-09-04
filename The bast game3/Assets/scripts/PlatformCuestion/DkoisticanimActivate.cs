using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DkoisticanimActivate : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    bool Activate = false;



    private void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SnowBoll"))
        {
            Activate = true;
        }

    }





    void Update()
    {
        if (Activate)
        {
            door.OpenDoor();
        }

    }

}


