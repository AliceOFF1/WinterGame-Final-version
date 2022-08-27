using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSwithSecond : MonoBehaviour
{ 
    [SerializeField] private GameObject doorGameObject;
    [SerializeField] private GameObject lampGameObject;    
    private IDoor door; 
    private IDoor lamp; 

    [SerializeField] private AudioSource Sound;
    [SerializeField] private AudioSource SoundOff;     

    private void Awake() 
    {
        door = doorGameObject.GetComponent<IDoor>();
        door = lampGameObject.GetComponent<IDoor>();

    }  

    public void OnTriggerStay2D(Collider2D collision) 
    {
    	if (collision.tag == "Player"  && transform.position.y >-6.050f) 
    	{
    		transform.Translate(Vector2.down * Time.deltaTime); 
            {
              Sound.Play(); 
              door.OpenDoor(); 
            }
    	} 

        if (collision.tag == "DestroyPoint"  && transform.position.y >-6.050f) 
        {
            transform.Translate(Vector2.down * Time.deltaTime); 
            { 
              Sound.Play(); 
              door.OpenDoor(); 
            }
        } 

        if (collision.tag == "Weapon" && transform.position.y >-6.050f) 
        {
            transform.Translate(Vector2.down * Time.deltaTime);
            { 
              Sound.Play();
              door.OpenDoor(); 
              lamp.OpenDoor();
            }
          
        }  

         if (collision.tag == "enemy" && transform.position.y >-6.050f) 
        {
            transform.Translate(Vector2.down * Time.deltaTime);
            { 
              Sound.Play();
              door.OpenDoor(); 
              lamp.OpenDoor();
            }
          
        } 
    }




    public void OnTriggerExit2D(Collider2D collision) 
    {

    		transform.position = new Vector2(transform.position.x, -6.050f);
            { 
              SoundOff.Play();
              door.OpenDoor(); 
            }
    }
}

