using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{ 
	public Transform player; 
	public Transform elevatorswitch; 
	public Transform downpos; 
	public Transform upperpos; 
	public SpriteRenderer lamp;  

    AudioSource audioSource;

    public AudioClip collectedClipOn;

	public float speed; 
	bool iselevatordown; 

    // Start is called before the first frame update
    void Start()
    {
        audioSource =GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        StartElevator(); 
        DisplayColor();
    }  

     public void PlaySound(AudioClip clip) 
   {
      audioSource.PlayOneShot(clip);
   }  

    void StartElevator() 

    {
    	if(Vector2.Distance(player.position,elevatorswitch.position)<0.5f && Input.GetKeyDown(KeyCode.E))
    	{
            
            
    		if(transform.position.y >=downpos.position.y)
    		{
    			iselevatordown =true;
                PlaySound(collectedClipOn);
    		} 
    		else if (transform.position.y <= upperpos.position.y) 
    		{
    			iselevatordown = false;
                PlaySound(collectedClipOn);
    		}
    	} 

    	if (iselevatordown) 
    	{
    		transform.position = Vector2.MoveTowards(transform.position,upperpos.position,speed * Time.deltaTime); 
             

    	} 
    	else 
    	{
    		transform.position = Vector2.MoveTowards(transform.position,downpos.position,speed * Time.deltaTime);
    	}
    } 

    void DisplayColor()
    {
    	if (transform.position.y >=downpos.position.y || transform.position.y <= upperpos.position.y) 
    	{
    		lamp.color = Color.green;
    	} 

    	else 
    	{
    		lamp.color = Color.red;
    	}
    }
}
