using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForCreateEnemySnow : MonoBehaviour
{

	public GameObject EnemySnow;
	public GameObject Particle;

	[SerializeField] private AudioSource Sound;

    // Start is called before the first frame update
    void Start()
    {
        EnemySnow.SetActive(false);
        Particle.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        

    	if (collision.CompareTag("Player")) 
    	{  
    		{
    			ExplodeTheObject();
    		}

    	}
    } 

    void ExplodeTheObject() 
    {
    	Particle.SetActive(true);
    	EnemySnow.SetActive(true);
    	Sound.Play();

    }

}

