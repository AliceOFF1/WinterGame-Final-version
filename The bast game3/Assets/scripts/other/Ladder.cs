using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    [SerializeField] 

    float speed = 1; 

    void OnTriggerStay2D(Collider2D other) 
    {   
    	other.GetComponent<Rigidbody2D>().gravityScale = 1;
    	if (other.gameObject.CompareTag("Player")&&Input.GetKey(KeyCode.W))
    		
            {
    			other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    		}   
        if (other.gameObject.CompareTag("Player")&& Input.GetKey(KeyCode.UpArrow))
                    
            {
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
            }   
        

        else if (other.gameObject.CompareTag("Player")&&Input.GetKey(KeyCode.S))
            
            {
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
            } 

        else if (other.gameObject.CompareTag("Player")&&Input.GetKey(KeyCode.DownArrow)) 
            
            {
                other.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
            } 
       
    	
    } 

    void OnTriggerExit2D(Collider2D other) 
    {
    	other.GetComponent<Rigidbody2D>().gravityScale =1;
    }

}
