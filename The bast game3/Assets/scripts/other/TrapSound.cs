using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSound : MonoBehaviour
{ 
	public AudioClip collectedClip;


	void OnTriggerEnter2D(Collider2D other)
	{
		PlayerController controller = other.GetComponent<PlayerController>(); 

		if (controller != null) 
		 
			{ 
				
				controller.PlaySound(collectedClip); 
										

			} 
		
	}

}