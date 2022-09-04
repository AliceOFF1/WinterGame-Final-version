using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainDoorCrashTrain : MonoBehaviour
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
        if (coll.gameObject.tag == "MountainDoor")
        {
            door.OpenDoor();
            Destroy(gameObject, 1);
        }
    }


}

