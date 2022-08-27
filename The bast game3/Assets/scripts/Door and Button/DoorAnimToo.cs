using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimToo : MonoBehaviour, IDoorToo
{
   private Animator animator; 
   private bool isOpen = false; 

   private void Awake() 
   {
   	animator = GetComponent<Animator>();
   } 

   public void OpenDoorToo()
   { 
   	isOpen = true;
   	animator.SetBool("Open", true); 
   } 

   public void CloseDoorToo()
   {
   	isOpen = false;
   	animator.SetBool("Open", false);
   }

   public void ToggleDoorToo()
   {
      isOpen = !isOpen; 
      if(isOpen) 
      {
         OpenDoorToo();
      } 
      else 
      {
         CloseDoorToo();
      }
   }

}
