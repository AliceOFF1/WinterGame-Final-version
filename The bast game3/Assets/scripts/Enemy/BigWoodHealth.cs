using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigWoodHealth : MonoBehaviour
{
    Vector2 pos;

    [SerializeField]
    int health = 2;
    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    public GameObject BigWoodObject;




    AudioSource audioSource;

    public AudioClip collectedClipOn;

    // Start is called before the first frame update

    private void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
    }

    void Start()
    {
        pos = transform.position;
        audioSource = GetComponent<AudioSource>();
        BigWoodObject.SetActive(false);
    }

    // Update is called once per frame


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
                BigWoodObject.SetActive(true);


            }


        }
    }

}
