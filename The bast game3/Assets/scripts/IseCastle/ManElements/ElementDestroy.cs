using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class ElementDestroy : MonoBehaviour
{ 
    public float timer; 
    private bool Activate;  


     void Start()
    {  
        Activate = false; 
        timer = 3f;
    }


   void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.name.Equals("Player")) 
   		
   		{ 
   			timer = 1.5f;
   			Activate = true;

   		}  

    } 

    void OnCollisionEnter2D (Collision2D coll)
   {
      if(coll.gameObject.tag =="wolf") 
       { 
        timer = 0.1f;
        Activate = true;;
      } 
   }
   
   

  

    private void Update() 
	{
		if (timer >0 && Activate == true) 
		{
			timer -= Time.deltaTime; 
			if(timer<=0f) 
			{
				Destroy(gameObject, 0.1f);
			}
		}
	}

} 
