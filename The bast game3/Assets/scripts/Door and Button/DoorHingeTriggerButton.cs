using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHingeTriggerButton : MonoBehaviour
{
    [SerializeField] private DoorHinge door;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            door.OpenDoorHinge();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            door.CloseDoorHinge();
        }
    }
}



