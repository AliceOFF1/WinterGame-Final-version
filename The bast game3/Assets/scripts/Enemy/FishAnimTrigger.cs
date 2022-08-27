using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAnimTrigger : MonoBehaviour
{
	[SerializeField] private GameObject doorGameObject;  
	private IDoor door;
	private float timer;  
	private bool StartAnim; 
	private bool Chek;


	private void Awake() 
	{
		door = doorGameObject.GetComponent<IDoor>();
	}  

	private void Update() 
	{
		if (timer >0) 
		{
			timer -= Time.deltaTime; 
			if(timer<=0f) 
			{
				door.CloseDoor();
			}
		}  

		if (StartAnim == true && Chek == true && Input.GetKeyDown(KeyCode.E))
		{
			door.OpenDoor();
		}

	}  


	
	private void OnTriggerEnter2D (Collider2D collider) 
	{
		if (collider.GetComponent<PlayerController>() != null) 
		{
			//Player entered collider! 
			StartAnim = true; 
		}

		if (collider.GetComponent<Chek>() != null) 
		{
			//Player entered collider! 
			Chek = true; 
		}

		
	}   

		

	
}
