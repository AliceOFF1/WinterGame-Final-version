using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxLithsWithTime : MonoBehaviour
{
	[SerializeField] private GameObject doorGameObject;  
	private IDoor door; 

	private void Awake() 
	{
		door = doorGameObject.GetComponent<IDoor>();
	}  

	

	private void OnTriggerEnter2D (Collider2D collider) 
	{
		if (collider.GetComponent<PlayerController>() != null) 
		{
			//Player entered collider! 
			door.OpenDoor(); 
		}

		if (collider.GetComponent<BarrelController>() != null) 
		{
			//Player entered collider! 
			door.OpenDoor(); 
		}
	}  

	private void OnTriggerStay2D(Collider2D collider) 
	{
		if(collider.GetComponent<PlayerController>() !=null) 
		{
			// Player still on top of collider! 
			door.OpenDoor();
		} 

		if(collider.GetComponent<BarrelController>() !=null) 
		{
			// Player still on top of collider! 
			door.OpenDoor();
		}
	} 

	private void OnTriggerExit2D (Collider2D collider) 
	{
		if (collider.GetComponent<PlayerController>() != null) 
		{
			//Player entered collider! 
			door.CloseDoor(); 
		}

		if (collider.GetComponent<BarrelController>() != null) 
		{
			//Player entered collider! 
			door.CloseDoor(); 
		}
	}  


}