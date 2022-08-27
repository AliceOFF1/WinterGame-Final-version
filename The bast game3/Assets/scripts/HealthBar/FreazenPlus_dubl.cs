using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreazenPlus_dubl : MonoBehaviour 
{ 
	
	
	void OnTriggerStay2D(Collider2D other)
	{
		PlayerController controller = other.GetComponent<PlayerController>(); 

		if (controller != null) 
		{ 
			if (controller.freazen < controller.maxFreazen)
			{ 

				controller.ChangeFreazen(+1); 
			    

			    
			} 
			
			
		}
	}

}

