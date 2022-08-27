using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShamanEffectAnimation : MonoBehaviour, IDoor
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
   	animator.SetBool("EffectActivate", true); 
   } 

   public void CloseDoor()
   {
   	isOpen = false;
   	animator.SetBool("EffectActivate", false);
     
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

