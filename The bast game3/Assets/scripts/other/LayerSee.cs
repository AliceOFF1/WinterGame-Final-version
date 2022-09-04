using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSee : MonoBehaviour
{
    private bool canSee = false;
    private bool ISee = false;
    private SpriteRenderer spriteRend;
    private SpriteRenderer rend;

    void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();
        rend = GetComponent<SpriteRenderer>();
    }




    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")

        {
            canSee = true;
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            canSee = false;
        }
    }


    void Update()
    {
        if (canSee == true)
        {
            Physics2D.IgnoreLayerCollision(8, 10, true);
            rend.sortingOrder = 0;
            ISee = true;
        }
        else
        {
            Physics2D.IgnoreLayerCollision(8, 10, false);
            rend.sortingOrder = 21;
            ISee = false;
        }
    }
}
