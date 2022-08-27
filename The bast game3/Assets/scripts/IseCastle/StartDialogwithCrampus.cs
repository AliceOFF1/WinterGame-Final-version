using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialogwithCrampus: MonoBehaviour
{ 
  private bool See = false;  
  public GameObject DialogTriggerBox;  
  public float sec = 1f;
  public GameObject Crampus;  


    
    void Start()
    { 
    	Crampus.SetActive(false);
        DialogTriggerBox.SetActive(false); 
    } 
 

    

    private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.name.Equals("Player"))  
         
         {
            DialogTriggerBox.SetActive(true);
            Crampus.SetActive(true);
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

       if (See == true && Input.GetKey(KeyCode.X)) 
      {
      	DialogTriggerBox.SetActive(false); 
      } 
      
	} 
}

