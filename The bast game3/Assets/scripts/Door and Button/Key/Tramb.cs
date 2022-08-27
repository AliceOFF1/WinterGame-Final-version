using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramb : MonoBehaviour
{
	[SerializeField] private TrambType trambType; 
	public GameObject DialogTriggerBox; 

	public void Start() 
	{
		DialogTriggerBox.SetActive(true);
	}

	public enum TrambType 
	{
		Red, 
		Green, 
		Blue
	} 

	public TrambType GetTrambType() 
	{
		return trambType;
	} 

	private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.name.Equals("Player"))  
         
         {
            DialogTriggerBox.SetActive(false);
         } 
    }    
}

