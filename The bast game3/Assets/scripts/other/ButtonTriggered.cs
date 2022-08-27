using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTriggereded : MonoBehaviour
{
	public Animator anim; 
	public GameObject frame; 
	public GameObject[] otherFrames; 

	private void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.CompareTag("Player")) 
		{
			anim.SetTrigger("IsTriggereded"); 
			frame.SetActive(true); 
			foreach(GameObject frame in otherFrames) 
			{
				frame.SetActive(false);
			}
		}
	}


	private void OnTriggerExit2D(Collider2D other) 
	
	{
		if (other.CompareTag("Player")) 
		{
			anim.SetTrigger("IsTriggereded");  
		}
	}
}
