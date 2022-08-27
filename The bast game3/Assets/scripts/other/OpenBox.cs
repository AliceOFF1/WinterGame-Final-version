using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{ 
	private bool See = false; 
   	public GameObject KeyToSpawn;  


  
    void OnCollisionEnter2D (Collision2D coll)
   {
      if(coll.gameObject.tag =="StoneDanger") 
      {
         See = true;
      }  
    }  

    
    void Update()
    {
       if (See == true) 
      {
        Destroy(gameObject); 
      	Instantiate(KeyToSpawn,transform.position, transform.rotation);
      } 
      
	} 
}

