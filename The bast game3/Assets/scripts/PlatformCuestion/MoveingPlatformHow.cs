using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveingPlatformHow : MonoBehaviour
{
    float speed = 0.5f;

    bool moveing = false;


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "TriggerPlatform")
        {
            moveing = true;
        }
    }

    void Start()
    {
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
    }

    void Stop()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
    }


    void Update()
    {
        if (moveing == true)
        {
            Start();
        }

        if (moveing == false)
        {
            Stop();
        }

    }



}
