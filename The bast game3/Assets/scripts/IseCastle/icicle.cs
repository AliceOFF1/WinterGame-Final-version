using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icicle : MonoBehaviour
{ 

	[SerializeField] 
	int health = 2; 

	[SerializeField] 
	Object destructable; 

    AudioSource audioSource;
    
    public AudioClip collectedClipOn;

    // Start is called before the first frame update
    void Start()
    {
        audioSource =GetComponent<AudioSource>();
    }

    // Update is called once per frame
    

    public void PlaySound(AudioClip clip) 
   {
      audioSource.PlayOneShot(clip);
   }  

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        

    	if (collision.CompareTag("DestroyPoint")) 
    	{  
    		health--;  

    		if (health < 0) 
    		{
    			ExplodeTheObject();
    		}

    	}
    } 


    void ExplodeTheObject() 
    {
    	GameObject destruct = (GameObject) Instantiate(destructable); 
    	destruct.transform.position = transform.position; 
    	Destroy(gameObject, 0.01f);
    }
}
