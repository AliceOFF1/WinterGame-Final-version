using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBarrelDestroy : MonoBehaviour
{
    public AudioClip collectedClipOn;
    public AudioClip collectedClipOff;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        DestroyObject controller = other.GetComponent<DestroyObject>();

        if (controller != null)

        {

            controller.PlaySound(collectedClipOn);

        }
    }




}