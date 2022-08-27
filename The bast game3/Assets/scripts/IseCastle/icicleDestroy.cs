using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class icicleDestroy : MonoBehaviour
{ 
    public float timer; 
    private bool Activate; 
    public GameObject GameObject;  



     void Start()
    {  
        Activate = false;
        GameObject.SetActive(true);
    }


   void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.name.Equals("Player")) 
   		
   		{ 
   			timer = 0.5f;
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
				GameObject.SetActive(false);
			}
		}
	}

} 
