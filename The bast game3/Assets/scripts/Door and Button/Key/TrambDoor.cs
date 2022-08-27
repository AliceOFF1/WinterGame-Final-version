using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrambDoor : MonoBehaviour
{
	[SerializeField] private Tramb.TrambType trambType;  

	private Animator animator; 
   	private bool isOpen = false;  

   	private void Awake() 
   {
   	animator = GetComponent<Animator>();
   } 

	public Tramb.TrambType GetTrambType() 
	{
		return trambType;
	} 

	public void OpenDoor() 
	{
		isOpen = true;
   		animator.SetBool("OpenShaman", true); 
	}

}
