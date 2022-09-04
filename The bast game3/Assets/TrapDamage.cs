using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDamage : MonoBehaviour
{
    public AudioClip collectedClip;


    void OnTriggerStay2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)

        {

            controller.PlaySound(collectedClip);


        }

    }

}
