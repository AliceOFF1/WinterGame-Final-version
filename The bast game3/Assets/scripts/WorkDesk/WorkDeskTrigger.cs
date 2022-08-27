using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkDeskTrigger: MonoBehaviour
{ 
  private bool See = false;  
  public GameObject WorkDeskUI;


    
    void Start()
    {
        WorkDeskUI.SetActive(false); 
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
      	WorkDeskUI.SetActive(true);
      } 

       if (Input.GetKey(KeyCode.X)) 
      {
      	WorkDeskUI.SetActive(false);
      } 
      
	} 
} 
