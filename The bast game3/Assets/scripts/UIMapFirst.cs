using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMapFirst : MonoBehaviour
{ 

	public GameObject Map_1; 
	bool Map_1Activate;
   
    void Start()
    {
        Map_1.SetActive(false); 
        Map_1Activate = false;
    } 

     private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.name.Equals("Player"))  
         
         {
            Map_1Activate = true;
         } 
    }    

        private void OnTriggerExit2D(Collider2D collision) 
    {
      if(collision.gameObject.name.Equals("Player"))  
         
         {
            Map_1Activate = false;
         } 
    }    


    // Update is called once per frame
    void Update()
    {
        if (Map_1Activate == true && Input.GetKey(KeyCode.E)) 
      {
      	Map_1.SetActive(true); 
      } 

       if (Map_1Activate == true && Input.GetKey(KeyCode.X)) 
      {
      	Map_1.SetActive(false); 
      } 

      if (Map_1Activate == false && Input.GetKey(KeyCode.X)) 
      {
      	Map_1.SetActive(false); 
      } 
    }
}