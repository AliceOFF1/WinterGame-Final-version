using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractButton: MonoBehaviour
{ 
	[SerializeField] private Transform playerTransform;


	private void Update() 
	{
		if (Input.GetKeyDown(KeyCode.E)) 
		{
			float interactRadius = 1f; 
			Collider2D[] collider2dArray = Physics2D.OverlapCircleAll(playerTransform.position, interactRadius); 
			foreach (Collider2D collider2d in collider2dArray) 
			{
				IDoorToo door = collider2d.GetComponent<IDoorToo>(); 
				if(door != null) 
				{
					//There's a Door in range! 
					door.ToggleDoorToo();
				}
			}
		}  
	}	
}
