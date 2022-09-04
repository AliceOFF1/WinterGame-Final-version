using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatformes : MonoBehaviour
{

    Rigidbody2D rb;
    Vector2 currrentPosition;
    bool moveingBack;
    private SpriteRenderer rend;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currrentPosition = transform.position;
        rend = GetComponent<SpriteRenderer>();

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player") && moveingBack == false)

        {
            Invoke("FallPlatform", 1f);
        }
    }



    void FallPlatform()
    {
        rb.isKinematic = false;
        Invoke("BackPlatform", 6f);
    }

    void BackPlatform()
    {
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
        moveingBack = true;
    }

    private void Update()
    {
        if (moveingBack == true)
        {
            rend.sortingOrder = 0;
            transform.position = Vector2.MoveTowards(transform.position, currrentPosition, 20f * Time.deltaTime);


        }

        if (transform.position.y == currrentPosition.y)
        {
            moveingBack = false;
            rend.sortingOrder = 7;
        }
    }
}


