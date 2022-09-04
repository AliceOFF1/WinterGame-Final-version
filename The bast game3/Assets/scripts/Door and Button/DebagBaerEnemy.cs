using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebagBaerEnemy : MonoBehaviour
{

    public GameObject Bear;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<WolfEnemy>() != null)
        {
            //Player entered collider! 
            Destroy(Bear);
        }
    }
}




