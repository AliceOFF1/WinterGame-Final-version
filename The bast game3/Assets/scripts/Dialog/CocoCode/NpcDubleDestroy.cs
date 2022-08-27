using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDubleDestroy : MonoBehaviour
{
   public DialogueTrigger trigger; 
   public GameObject press;  
   public GameObject pressSecond; 

   private void OnCollisionEnter2D(Collision2D collision) 
   {
   	if (collision.gameObject.CompareTag("Player") == true) 
   	{
   		trigger.StartDialogue(); 
   		Destroy(pressSecond,2f);   
   		{
   			Destroy(press,2f); 
   		}
   	}
   
   }  

 

}