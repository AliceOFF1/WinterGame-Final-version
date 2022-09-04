using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatPlus : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            if (controller.eat < controller.maxEat)
            {

                controller.ChangeEat(+10);
                Destroy(gameObject);
            }


        }
    }

}
