using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntennaTriggerAnim : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    private float timer;
    private bool KeyActivate;

    void Start()
    {
        door.CloseDoor();
        KeyActivate = false;
    }

    private void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<KeyController>() != null)
        {
            //Player entered collider! 
            KeyActivate = true;
        }

    }


    void Update()
    {

        if (KeyActivate == true && Input.GetKey(KeyCode.E))
        {
            door.OpenDoor();
        }

    }




}
