using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            if (controller.eat < controller.maxEat)
            {

                controller.ChangeHealth(+50);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }


        }
    }

}

