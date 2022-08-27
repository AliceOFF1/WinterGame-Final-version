using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShamanSetActive: MonoBehaviour
{ 
  private bool See = false;  
  public GameObject Effect;  
  

    
    void Start()
    {
        Effect.SetActive(false); 
    } 
 

    

    private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.name.Equals("Player"))  
         
         {
            See = true;
         } 
    }    

        private void OnTriggerExit2D(Collider2D collision) 
    {
      if(collision.gameObject.name.Equals("Player"))  
         
         {
            See = false;
         } 
    }   

    
    void Update()
    {
       if (See == true && Input.GetKey(KeyCode.E)) 
      {
      	Effect.SetActive(true);
      } 

	} 
} 
