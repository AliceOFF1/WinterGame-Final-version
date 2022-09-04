using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMountainDoor : MonoBehaviour
{

    [SerializeField]
    public int health = 5;
    public GameObject E;
    public GameObject Message;
    public GameObject BlockExit;

    private Animator animator;

    [SerializeField] private AudioSource Sound;

    // Start is called before the first frame update 

    public void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("DestroyPoint"))
        {
            health--;
            Sound.Play();

            if (health < 0)
            {
                ExplodeTheObject();

            }

        }
    }


    void ExplodeTheObject()
    {
        Destroy(E);
        Destroy(Message);
        Sound.Play();
        animator.SetBool("MountainDoorDestroy", true);
        Destroy(BlockExit);


    }
}
