using System.Collections.Generic;
using UnityEngine;

public class HandleCastlePlatform : MonoBehaviour, IDoor
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
   	animator.SetBool("HandleCastlePlatform", true); 
   } 

   public void CloseDoor()
   {
   	isOpen = false;
   	animator.SetBool("HandleCastlePlatform", false);
     
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
