using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodAnimation : MonoBehaviour, IWood
{ 

   private Animator animator; 
   private bool isActive = false; 

   private void Awake() 
   {
   	animator = GetComponent<Animator>();
   } 

   public void StartWood()
   { 
   	isActive = true;
   	animator.SetBool("Active", true); 
   } 

   public void FinishWood()
   {
   	isActive = false;
   	animator.SetBool("Active", false);
     
   }

   public void ToggleWood()
   {
      isActive = !isActive; 
      if(isActive) 
      {
         StartWood();
      } 
      else 
      {
         FinishWood();
      }
   }

}
