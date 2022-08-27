using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DjoisticHow : MonoBehaviour, IDoor
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
   	animator.SetBool("OpenDjoistikSecond", true); 
   } 

   public void CloseDoor()
   {
   	isOpen = false;
   	animator.SetBool("OpenDjoistikSecond", false);
     
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
