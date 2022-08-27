using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleAnimated : MonoBehaviour, IDoor
{ 

   private Animator animator; 
   private bool isOpen = false; 

   private void Awake() 
   {
   	animator = GetComponent<Animator>();
   } 

   public void OpenDoor()
   { 
   	isOpen = true;
   	animator.SetBool("OpenDjoistik", true); 
   } 

   public void CloseDoor()
   {
   	isOpen = false;
   	animator.SetBool("OpenDjoistik", false);
     
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

}