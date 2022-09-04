using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IseDie : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    private float timer;
    public GameObject trigger;









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




    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<IseAnimTrigger>() != null)
        {
            //Player entered collider! 
            door.OpenDoor();
            Destroy(trigger, 7f);

        }


    }



}