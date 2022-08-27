using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleForStairsAnim : MonoBehaviour
{
	[SerializeField] private GameObject doorGameObject;  
	private IDoor door;
	bool Activate = false;



	private void Awake() 
	{
		door = doorGameObject.GetComponent<IDoor>();  
	}   

	

	private void OnTriggerEnter2D(Collider2D collider) 
    
    {
    	if(collider.GetComponent<PlayerController>() != null)  
			//Player entered collider! 
		{
			 Activate = true;
		}
			
	} 

	private void OnTriggerExit2D(Collider2D collider) 
    
    {
    	if(collider.GetComponent<PlayerController>() != null)  
			//Player entered collider! 
		{
			 Activate = false;
		}
			
	}     

	


	
	void Update()
    {
       if (Activate && Input.GetKey(KeyCode.F))
       {
       	door.OpenDoor();
       } 

         if (Activate && Input.GetKey(KeyCode.G))
       {
       	door.CloseDoor();
       }

    } 

} 

