using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveingPlatform : MonoBehaviour
{
   float dirX; 
   float speed = 0.5f; 

   bool moveingRight = true;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x> 66.3f)
        {
        	moveingRight = false;
        } 

        else if(transform.position.x < 57.7f) 
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
