using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForAnimatiionShaman : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    [SerializeField] private GameObject doorGameObject2;
    [SerializeField] private GameObject doorGameObject3;
    [SerializeField] private GameObject doorGameObject4;
    [SerializeField] private GameObject doorGameObject5;
    [SerializeField] private GameObject doorGameObject6;
    [SerializeField] private GameObject doorGameObject7;
    [SerializeField] private GameObject doorGameObject8;
    [SerializeField] private GameObject doorGameObject9;
    [SerializeField] private GameObject doorGameObject10;
    [SerializeField] private GameObject doorGameObject11;
    [SerializeField] private GameObject doorGameObject12;
    [SerializeField] private GameObject doorGameObject13;
    [SerializeField] private GameObject doorGameObject14;
    [SerializeField] private GameObject doorGameObject15;
    [SerializeField] private GameObject doorGameObject16;
    [SerializeField] private GameObject doorGameObject17;
    [SerializeField] private GameObject doorGameObject18;
    [SerializeField] private GameObject doorGameObject19;
    [SerializeField] private GameObject doorGameObject20;
    [SerializeField] private GameObject doorGameObject21;
    [SerializeField] private GameObject doorGameObject22;
    private IDoor door;
    private IDoor door2;
    private IDoor door3;
    private IDoor door4;
    private IDoor door5;
    private IDoor door6;
    private IDoor door7;
    private IDoor door8;
    private IDoor door9;
    private IDoor door10;
    private IDoor door11;
    private IDoor door12;
    private IDoor door13;
    private IDoor door14;
    private IDoor door15;
    private IDoor door16;
    private IDoor door17;
    private IDoor door18;
    private IDoor door19;
    private IDoor door20;
    private IDoor door21;
    private IDoor door22;

    bool Activate = false;

    public GameObject HouseLayer;
    public GameObject ShamanLayer;


    private void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
        door2 = doorGameObject2.GetComponent<IDoor>();
        door3 = doorGameObject3.GetComponent<IDoor>();
        door4 = doorGameObject4.GetComponent<IDoor>();
        door5 = doorGameObject5.GetComponent<IDoor>();
        door6 = doorGameObject6.GetComponent<IDoor>();
        door7 = doorGameObject7.GetComponent<IDoor>();
        door8 = doorGameObject8.GetComponent<IDoor>();
        door9 = doorGameObject9.GetComponent<IDoor>();
        door10 = doorGameObject10.GetComponent<IDoor>();
        door11 = doorGameObject11.GetComponent<IDoor>();
        door12 = doorGameObject12.GetComponent<IDoor>();
        door13 = doorGameObject13.GetComponent<IDoor>();
        door14 = doorGameObject13.GetComponent<IDoor>();
        door15 = doorGameObject13.GetComponent<IDoor>();
        door16 = doorGameObject13.GetComponent<IDoor>();
        door17 = doorGameObject13.GetComponent<IDoor>();
        door18 = doorGameObject13.GetComponent<IDoor>();
        door19 = doorGameObject13.GetComponent<IDoor>();
        door20 = doorGameObject13.GetComponent<IDoor>();
        door21 = doorGameObject13.GetComponent<IDoor>();
        door22 = doorGameObject13.GetComponent<IDoor>();

    }



    private void OnTriggerEnter2D(Collider2D collider)

    {
        if (collider.GetComponent<PlayerController>() != null)
        //Player entered collider! 
        {
            Activate = true;
        }

    }




    private void Update()
    {
        if (Activate == true && Input.GetKeyDown(KeyCode.X))
        {
            door.OpenDoor();
            door2.OpenDoor();
            door3.OpenDoor();
            door4.OpenDoor();
            door5.OpenDoor();
            door6.OpenDoor();
            door7.OpenDoor();
            door8.OpenDoor();
            door9.OpenDoor();
            door10.OpenDoor();
            door11.OpenDoor();
            door12.OpenDoor();
            door13.OpenDoor();
            door14.OpenDoor();
            door15.OpenDoor();
            door16.OpenDoor();
            door17.OpenDoor();
            door18.OpenDoor();
            door19.OpenDoor();
            door20.OpenDoor();
            door21.OpenDoor();
            door22.OpenDoor();
            {
                ShamanLayer.SetActive(false);
                HouseLayer.SetActive(true);
            }


        }


        if (Activate == false)
        {
            door.CloseDoor();
            door2.CloseDoor();
            door3.CloseDoor();
            door4.CloseDoor();
            door5.CloseDoor();
            door6.CloseDoor();
            door7.CloseDoor();
            door8.CloseDoor();
            door9.CloseDoor();
            door10.CloseDoor();
            door11.CloseDoor();
            door12.CloseDoor();
            door13.CloseDoor();
            door14.CloseDoor();
            door15.CloseDoor();
            door16.CloseDoor();
            door17.CloseDoor();
            door18.CloseDoor();
            door19.CloseDoor();
            door20.CloseDoor();
            door21.CloseDoor();
            door22.CloseDoor();

            ShamanLayer.SetActive(true);
            HouseLayer.SetActive(false);
        }

    }

}

