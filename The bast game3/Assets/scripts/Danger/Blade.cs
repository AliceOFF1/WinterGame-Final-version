using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{ 
	public float rotatespeed; 
	public float speed; 
	public Transform pos1; 
	public Transform pos2; 
	bool turnback; 

    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0,0, rotatespeed); 
        if(transform.position.x >= pos1.position.x)
        {
        	turnback = true;
        }

        if(transform.position.x <= pos2.position.x)
        {
        	turnback = false;
        } 

        if(turnback) 
        {
        	transform.position = Vector2.MoveTowards(transform.position,pos2.position,speed* Time.deltaTime);
        }

        else
        {
        	transform.position = Vector2.MoveTowards(transform.position,pos1.position,speed* Time.deltaTime);
        }
    }
}
