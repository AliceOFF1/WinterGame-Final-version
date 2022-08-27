using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAndHandle : MonoBehaviour
{
	[SerializeField] private GameObject doorGameObject;  
	private IDoor door;
	bool Activate = false; 
	bool Sounds = false; 

	[SerializeField] private AudioSource Sound;



	private void Awake() 
	{
		door = doorGameObject.GetComponent<IDoor>();  
	}   

	

	private void OnTriggerEnter2D(Collider2D collider) 
    
    {
    	if(collider.GetComponent<PlayerController>() != null)  
			//Player entered collider! 
		{
			 Activate = true; 
			 Sounds = true;
		}
			
	}  

	private void OnTriggerExit2D(Collider2D collider) 
    
    {
    	if(collider.GetComponent<PlayerController>() != null)  
			//Player entered collider! 
		{
			 Sounds = false;
		}
			
	}   
 

	


	
	void Update()
    {
       if (Activate && Input.GetKey(KeyCode.F))
       {
       	door.OpenDoor();
       }  

       if (Sounds && Input.GetKey(KeyCode.F)) 
       {
       	Sound.Play();
       }

    } 

} 
