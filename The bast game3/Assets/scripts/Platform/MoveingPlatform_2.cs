using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveingPlatform_2 : MonoBehaviour
{
    float dirX;
    float speed = 0.5f;

    bool moveingRight = true;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 46.86f)
        {
            moveingRight = false;
        }

        else if (transform.position.x < 55.7f)
        {
            moveingRight = true;
        }

        if (moveingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }

        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
