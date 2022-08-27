using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainDoor : MonoBehaviour
{
	[SerializeField] private Key.KeyType keyType;  

	private Animator animator; 
   	private bool isOpen = false;  

   	private void Awake() 
   {
   	animator = GetComponent<Animator>();
   } 

	public Key.KeyType GetKeyType() 
	{
		return keyType;
	} 

	public void OpenDoor() 
	{
		isOpen = true;
   		animator.SetBool("trolley", true); 
	}

}

