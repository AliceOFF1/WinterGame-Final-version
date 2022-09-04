using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMinus : MonoBehaviour
{
    public AudioClip collectedClip;
    public ParticleSystem damageEffect;

    void OnTriggerStay2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)

        {
            controller.ChangeHealth(-10);
            controller.PlaySound(collectedClip);
            Instantiate(damageEffect);
            Destroy(gameObject);


        }

    }

}
