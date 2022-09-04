using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicRatDamage : MonoBehaviour
{
    public AudioClip collectedClipOn;
    public AudioClip collectedClipOff;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        Enemy controller = other.GetComponent<Enemy>();

        if (controller != null)

        {

            controller.PlaySound(collectedClipOn);

        }
    }




}