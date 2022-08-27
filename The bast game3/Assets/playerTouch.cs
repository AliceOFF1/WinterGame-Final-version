using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTouch : MonoBehaviour
{
	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } 


     private void OnTriggerEnter2D(Collider2D collision) 
   {
        PlayerController controller = GetComponent<PlayerController>(); 
      
     
      if(collision.gameObject.tag == "obs") 
        
        {
            controller.ChangeHealth(-35);
        } 


      if(collision.gameObject.tag == "woodobs") 
        
        {
            controller.ChangeHealth(-100);
        }   
    }
} 


