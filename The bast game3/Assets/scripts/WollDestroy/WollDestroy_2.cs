using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WollDestroy_2 : MonoBehaviour
{

    private bool canSee = true;
    private bool ISee = true;
    private SpriteRenderer spriteRend;
    private SpriteRenderer rend;
    public GameObject woll;
    private float timer;


    void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();
        rend = GetComponent<SpriteRenderer>();
        woll.SetActive(false);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("DestroyPoint"))
        {
            canSee = false;
            timer = 0.1f;

        }
    }

    void Update()
    {

        if (canSee == false && timer >= 0)
        {
            rend.sortingOrder = 0;
            ISee = false;
            woll.SetActive(true);
        }
        else
        {
            rend.sortingOrder = 24;
            ISee = true;
        }
    }




}

