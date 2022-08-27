using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelController : MonoBehaviour
{   

  public GameObject MountainDoor; 
	AudioSource audioSource;
    
    public AudioClip collectedClipOn;
    // Start is called before the first frame update


    // Update is called once per frame 

	 void Start()
    {
        audioSource =GetComponent<AudioSource>();
    }

    

   void OnCollisionEnter2D (Collision2D coll)
   {
      if(coll.gameObject.tag =="Train") 
      {
         Destroy(gameObject);  
         Destroy(MountainDoor);
      } 
      
  }  

}
