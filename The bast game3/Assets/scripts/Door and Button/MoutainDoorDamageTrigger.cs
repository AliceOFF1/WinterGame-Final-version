using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoutainDoorDamageTrigger : MonoBehaviour

{
    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    private float timer;
    public GameObject MountainDoor;
    public GameObject E;
    public GameObject Message;
    public GameObject MountainDoorTrigger;

    [SerializeField]
    int health = 200;

    AudioSource audioSource;

    public AudioClip collectedClipOn;

    void Start()
    {
        MountainDoor.SetActive(true);
        E.SetActive(true);
        Message.SetActive(true);
        MountainDoorTrigger.SetActive(true);
    }


    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("DestroyPoint"))
        {
            health--;

            if (health < 0)
            {
                door.OpenDoor();

            }


        }
    }



}