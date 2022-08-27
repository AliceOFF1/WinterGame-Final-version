using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titr : MonoBehaviour
{ 
	public GameObject titr; 
	bool titrActivate;
   
    void Start()
    {
        titr.SetActive(false); 
        titrActivate = false;
    }

    // Update is called once per frame
      

       private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.name.Equals("Player"))  
    	{
    		titrActivate = true;
    	} 
    }

   void Update()
    {
        if (titrActivate == true && Input.GetKey(KeyCode.X))
        {
        	titr.SetActive(true);
        }
    }  
}
