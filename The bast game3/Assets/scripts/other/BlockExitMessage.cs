using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockExitMessage: MonoBehaviour
{ 
  private bool See = false;  
  public GameObject DialogTriggerBox;  
  public float sec = 1f; 


    
    void Start()
    {
        DialogTriggerBox.SetActive(false); 
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
       if (See == true) 
      {
      	DialogTriggerBox.SetActive(true);
      } 

       if (See == false) 
      {
      	DialogTriggerBox.SetActive(false);
      } 
      
	} 
}
