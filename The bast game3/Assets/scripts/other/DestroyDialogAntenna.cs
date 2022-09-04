using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDialogAntenna : MonoBehaviour
{

    public GameObject DialogTriggerAntenna;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name.Equals("antenna"))

        {
            Destroy(DialogTriggerAntenna);
        }

    }

}
