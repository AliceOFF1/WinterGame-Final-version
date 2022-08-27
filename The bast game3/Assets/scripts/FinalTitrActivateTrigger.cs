using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTitrActivateTrigger : MonoBehaviour
{ 
	public GameObject titrtrigger;
	bool titrActivatetrigger;
   
    void Start()
    {
        titrtrigger.SetActive(false); 
        titrActivatetrigger = false;
    }

    // Update is called once per frame
      

       private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.name.Equals("Player"))  
    	{
    		titrActivatetrigger = true;
    	} 
    }

   void Update()
    {
        if (titrActivatetrigger == true && Input.GetKey(KeyCode.E))
        {
        	titrtrigger.SetActive(true);
        }
    }  
}


