using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSwith : MonoBehaviour
{ 

    [SerializeField] private AudioSource Sound;
    [SerializeField] private AudioSource SoundOff;     
 

  

    public void OnTriggerStay2D(Collider2D collision) 
    {
    	if (collision.tag == "Player"  && transform.position.y >-8.46f) 
    	{
            Sound.Play();
    		transform.Translate(Vector2.down * Time.deltaTime);
    	} 

        if (collision.tag == "Weapon" && transform.position.y >-8.46f) 
        {
            Sound.Play();
            transform.Translate(Vector2.down * Time.deltaTime);
        }  

         if (collision.tag == "enemy" && transform.position.y >-8.46) 
        {
            Sound.Play();
            transform.Translate(Vector2.down * Time.deltaTime);
        } 
    } 



    public void OnTriggerExit2D(Collider2D collision) 
    {
            SoundOff.Play();
    		transform.position = new Vector2(transform.position.x,-8.45f);
    }
}
