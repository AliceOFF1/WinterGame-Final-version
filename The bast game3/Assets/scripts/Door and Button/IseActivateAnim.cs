using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IseActivateAnim : MonoBehaviour
{
	[SerializeField] private GameObject doorGameObject;  
	private IDoor door;  
	private float timer; 
	public GameObject IseGround;

	private void Awake() 
	{
		door = doorGameObject.GetComponent<IDoor>();
	}  



	private void OnTriggerEnter2D (Collider2D collider) 
	{
		if (collider.GetComponent<WolfEnemy>() != null) 
		{
			//Player entered collider! 
			door.OpenDoor();  
			timer = 1f;
		}
	}  

	private void OnTriggerStay2D(Collider2D collider) 
	{
		if(collider.GetComponent<WolfEnemy>() !=null) 
		{
			// Player still on top of collider! 
			door.OpenDoor();
		} 
	} 

	private void OnTriggerExit2D(Collider2D collider) 
	{
		if(collider.GetComponent<WolfEnemy>() !=null) 
		{
			// Player still on top of collider! 
			door.OpenDoor();
		} 
	}  

	private void Update() 
	{
		if (timer >0) 
		{
			timer -= Time.deltaTime; 
			if(timer<=0f) 
			{
				Destroy(IseGround);
			}
		}
	}


}

