using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EDestroyToo : MonoBehaviour
{ 
	private bool enter = false;  
	public GameObject Message;
    // Start is called before the first frame update
   

      private void OnTriggerEnter2D(Collider2D collision) 
   {
      
     
      if(collision.gameObject.tag =="Weapon") 
   		
   		{
   			enter = true;
   		}  

   	}

  void Update()
  {
  	if(enter == true && Input.GetKeyDown(KeyCode.F) ) 
  	{	
  		Destroy(Message);
  		Destroy(gameObject);
  	}
  }
}

