using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WollDestroy : MonoBehaviour
{ 

  private bool canSee = true;
  private bool ISee = true;
  private SpriteRenderer spriteRend;  
  private SpriteRenderer rend;
  public GameObject woll; 
    

	void Start()
    	{
        spriteRend = GetComponent<SpriteRenderer>();
        rend = GetComponent<SpriteRenderer>(); 
        woll.SetActive(false); 
    	} 

    

    private void OnTriggerEnter2D(Collider2D collision) 
    {        

    	if (collision.CompareTag("DestroyPoint")) 
    	{ 
  			canSee = false;
       		
    	}
    } 

    void Update()
    {
    
       if (canSee == false) 
      {
         rend.sortingOrder = 0; 
         ISee = false;
         woll.SetActive(true); 
      } 
      else 
      {
         rend.sortingOrder = 25; 
         ISee = true;
      }  
    }

     
    
     
}
