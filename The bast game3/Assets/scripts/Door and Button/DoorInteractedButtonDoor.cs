using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractedButtonDoor : MonoBehaviour
{
	[SerializeField] private GameObject doorGameObject;  
	[SerializeField] private Transform playerTransform;
	private IDoorToo door;

	private void Awake() 
	{
		door = doorGameObject.GetComponent<IDoorToo>();
	}  

	private void Update() 
	{
		if (Input.GetKeyDown(KeyCode.E)) 
		{
			float interactRadius = 2f; 
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
