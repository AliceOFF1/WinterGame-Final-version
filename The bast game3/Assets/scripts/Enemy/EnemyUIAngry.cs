using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUIAngry : MonoBehaviour
{
	public float speed; 

	public int positionOfPatrol; 
	public Transform point; 
	bool moveingRight; 
    bool isFacingRight = true;

	Transform player; 
	public float stoppingDistance;  
	public float AttacDistance;

	bool chill = false; 
	bool angry = false; 
	bool goBack = false; 

	float Vector1;
    
    void Start()
    {
		player = GameObject.FindGameObjectWithTag("Player").transform;        
    }

    
    void Update()
    {
        if(Vector2.Distance(transform.position, point.position) < positionOfPatrol && angry == false) 
        {
        	chill = true;
        } 

        if (Vector2.Distance(transform.position, player.position) < stoppingDistance) 
        {
        	angry = true; 
        	chill = false; 
        	goBack = false;
        }

        if (Vector2.Distance(transform.position, player.position) > stoppingDistance) 
        {
        	goBack = true; 
        	angry = false;
        } 

        if (chill == true) 
        {
        	Chill();
        } 

        else if (angry == true)
        {
        	Angry();
        } 

        else if (goBack == true) 
        {
        	GoBack();
        }
    } 

    void Chill() 
    {
    	if (transform.position.x > point.position.x + positionOfPatrol) 
    	{
    		moveingRight = false;
            Flip(); 
            
            
    	} 
    	
    	else if (transform.position.x < point.position.x - positionOfPatrol) 
    	{
    		moveingRight = true;
            Flip(); 
            
            
            
    	}  
    	
    	if (moveingRight) 
    	{
    		transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);


            
    	} 
    	
    	else 
    	{
    		transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

            
    	} 
    	

    } 

    void Angry() 
    {	
    	if(Vector2.Distance(transform.position, player.position)>AttacDistance)
        {
    	       transform.position = Vector2.MoveTowards(transform.position, player.position , speed * Time.deltaTime); 
               
 
                
        }
    	
    } 

    void GoBack() 
    {
    	transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime); 
        Flip(); 

        
    } 

    void Flip() 
    {
        isFacingRight = !isFacingRight; 
        Vector3 theScale = transform.localScale; 
        theScale.x *= -1; 
        transform.localScale = theScale;
    }
}
