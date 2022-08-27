using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodDestroyParticle : MonoBehaviour
{  
    public int maxHealth = 100;
    int currentHealth;
    private bool See; 
    

    [SerializeField] 

    private UnityEngine.Object explosion;

    void Start()
    { 
        explosion = Resources.Load("ParticleSystem"); 
        currentHealth = maxHealth; 
        See = false;
    }

       
   

  
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        

        if (collision.CompareTag("DestroyPoint")) 
        { 
            See = true;
            GameObject explosionRef = (GameObject)Instantiate(explosion); 
            explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);   
    
        }  
    }

    

    void Update()
    {
       if (See == true && Input.GetKeyDown(KeyCode.Mouse0))
      {
        currentHealth -=15; 
      } 

      if (currentHealth <= 0) 
            {  
                

            }
    }

}  

