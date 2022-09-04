using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlus : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {

                controller.ChangeHealth(+10);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }


        }
    }

}
