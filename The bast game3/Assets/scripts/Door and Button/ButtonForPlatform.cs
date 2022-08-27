using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonForPlatform : MonoBehaviour
{ 
	public AudioClip collectedClipOn;
	public AudioClip collectedClipOff;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D collision) 
    {
    	if (collision.tag == "Player"  && transform.position.y >-4.42f) 
    	{
    		transform.Translate(Vector2.down * Time.deltaTime); 
    	} 

        if (collision.tag == "Weapon" && transform.position.y >-4.42f) 
        {
            transform.Translate(Vector2.down * Time.deltaTime);
          
        }  

         if (collision.tag == "enemy" && transform.position.y >-4.42f) 
        {
            transform.Translate(Vector2.down * Time.deltaTime);
          
        } 
    } 

    void OnTriggerEnter2D(Collider2D other)
	{
		PlayerController controller = other.GetComponent<PlayerController>(); 

		if (controller != null) 
		 
			{ 
				
				controller.PlaySound(collectedClipOn); 
										

			}   
	}



    public void OnTriggerExit2D(Collider2D collision) 
    {

    		transform.position = new Vector2(transform.position.x, -4.388f);
    }
}
