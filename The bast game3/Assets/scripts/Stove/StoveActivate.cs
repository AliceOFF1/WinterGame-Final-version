using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveActivate: MonoBehaviour
{
	[SerializeField] private GameObject stoveGameObject; 
	[SerializeField] private GameObject smokeGameObject;   
	private IDoor stove;
	private IDoor smoke;
	public GameObject FreazenPlus;

	private void Awake() 
	{
		stove = stoveGameObject.GetComponent<IDoor>();
		smoke = smokeGameObject.GetComponent<IDoor>();
	}   

	public void Start() 
	{
		FreazenPlus.SetActive(false);
	}

	
	private void OnTriggerEnter2D (Collider2D collider) 
	{
		if (collider.GetComponent<WoodFuel>() != null) 
		{
			//Player entered collider! 
			stove.OpenDoor(); 
			smoke.OpenDoor(); 
			FreazenPlus.SetActive(true);
			Debug.Log("!");
		}

		
	}  
		

	
}