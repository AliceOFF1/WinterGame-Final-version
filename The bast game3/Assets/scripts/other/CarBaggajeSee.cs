using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBaggajeSee : MonoBehaviour
{ 
    private Animator animator; 
    private bool isOpen = false;
	  private bool See = false; 
   	private bool ItemSee = false;
   	private SpriteRenderer spriteRend;  
   	private SpriteRenderer rend; 
   	public GameObject objectToSpawn;  
    public GameObject objectCar;  


    
    void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();
        rend = GetComponent<SpriteRenderer>();  
        objectToSpawn.SetActive(false);
    } 

    private void Awake() 
   {
    animator = GetComponent<Animator>();
   }

    
     public void OpenDoor()
   { 
    isOpen = true;
    animator.SetBool("CarAnim", true); 
   } 

   public void CloseDoor()
   {
    isOpen = false;
    animator.SetBool("CarAnim", false);
     
   }

   public void ToggleDoor()
   {
      isOpen = !isOpen; 
      if(isOpen) 
      {
         OpenDoor();
      } 
      else 
      {
         CloseDoor();
      }
   }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.name.Equals("Player"))  
         
         {
            See = true;
         } 
    }    

 

 

    
    void Update()
    {
       if (See == true && Input.GetKey(KeyCode.E)) 
      {
        Destroy(gameObject); 
        Instantiate(objectCar,transform.position, transform.rotation); 
        OpenDoor();
      	objectToSpawn.SetActive(true);
      } 
      
	} 
}

