using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrampusDangeZone : MonoBehaviour
{
    


	 void OnCollisionEnter2D(Collision2D other)
    {

        PlayerController controller = other.gameObject.GetComponent<PlayerController>(); 

        if (controller != null) 
         
            { 
                controller.ChangeHealth(-100);  
            }  

       
    }  

} 

