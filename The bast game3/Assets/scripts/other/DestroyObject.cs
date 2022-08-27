using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{  
	public GameObject objectToSpawn;
	bool isShacking = false;  
	float shake = 0.01f; 
	Vector2 pos;

	[SerializeField] 
	int health = 2; 

	[SerializeField] 
	Object destructable; 

    AudioSource audioSource;
    
    public AudioClip collectedClipOn;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        audioSource =GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
     	if (isShacking == true) 
     	{
     		transform.position = pos + UnityEngine.Random.insideUnitCircle * shake;
     	}   
    }  

    public void PlaySound(AudioClip clip) 
   {
      audioSource.PlayOneShot(clip);
   }  

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        

    	if (collision.CompareTag("DestroyPoint")) 
    	{
    		isShacking = true;  
    		health--;  

    		if (health < 0) 
    		{
    			ExplodeTheObject();
    		}

    		Invoke("StopShaking", .5f);
    	}
    } 

    void StopShaking() 
    {
    	isShacking = false; 
    	transform.position = pos;
    } 

    void ExplodeTheObject() 
    {
    	GameObject destruct = (GameObject) Instantiate(destructable); 
    	destruct.transform.position = transform.position; 
    	Instantiate(objectToSpawn,transform.position, transform.rotation);
    	Destroy(gameObject, 0.1f);
    }
}
