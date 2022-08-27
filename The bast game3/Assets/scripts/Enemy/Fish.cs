using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour, IDoor
{ 

   private Animator animator; 
   private bool isOpen = false; 
   public GameObject objectToSpawn;
   private bool isFishing = false;  
   public GameObject GameObject;

   private void Start()
   {
   	objectToSpawn.SetActive(false); 
   	GameObject.SetActive(true);
   }

   private void Awake() 
   {
   	animator = GetComponent<Animator>();
   } 

   public void OpenDoor()
   { 
   	isOpen = true;
   	animator.SetBool("fish", true); 
   } 

   public void CloseDoor()
   {
   	isOpen = false;
   	animator.SetBool("fish", false);
     
   }

   public void ToggleDoor()
   {
      isOpen = !isOpen; 
      if(isOpen) 
      {
         OpenDoor();
      } 
      else 
      {
         CloseDoor();
      }
    
    }
	
	
	 public void OnTriggerEnter2D(Collider2D collision)  
	{
		
		if(collision.gameObject.name.Equals("Fishing")) 
   		
   		{
   			isFishing = true; 

   		} 
		
	}   

	 public void OnTriggerExit2D(Collider2D collision)  
	{
		
		if(collision.gameObject.name.Equals("Fishing")) 
   		
   		{
   			isFishing = false; 

   		} 
		
	}   

   private void Update()

	{
		if (isFishing == true)
		{
			objectToSpawn.SetActive(true);
			GameObject.SetActive(false);

		}
	}
		
	
}


