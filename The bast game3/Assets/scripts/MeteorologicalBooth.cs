using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorologicalBooth : MonoBehaviour
{ 

	public GameObject Booth; 
	bool BoothActivate;
   
    void Start()
    {
        Booth.SetActive(false); 
        BoothActivate = false;
    } 

     private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.name.Equals("Player"))  
         
         {
            BoothActivate = true;
         } 
    }    

        private void OnTriggerExit2D(Collider2D collision) 
    {
      if(collision.gameObject.name.Equals("Player"))  
         
         {
            BoothActivate = false;
         } 
    }    


    // Update is called once per frame
    void Update()
    {
        if (BoothActivate == true && Input.GetKey(KeyCode.E)) 
      {
      	Booth.SetActive(true); 
      } 

       if (BoothActivate == true && Input.GetKey(KeyCode.X)) 
      {
      	Booth.SetActive(false); 
      } 

      if (BoothActivate == false && Input.GetKey(KeyCode.X)) 
      {
      	Booth.SetActive(false); 
      } 
    }
}
