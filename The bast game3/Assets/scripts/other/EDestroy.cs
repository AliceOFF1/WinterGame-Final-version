using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EDestroy : MonoBehaviour
{ 
	private bool enter = false; 
    // Start is called before the first frame update
   

      private void OnTriggerEnter2D(Collider2D collision) 
   {
      
     
      if(collision.gameObject.name.Equals("Player")) 
   		
   		{
   			enter = true;
   		}  
  }   

  void Update()
  {
  	if(enter == true && Input.GetKeyDown(KeyCode.E) ) 
  	{
  		Destroy(gameObject);
  	}
  }
}

