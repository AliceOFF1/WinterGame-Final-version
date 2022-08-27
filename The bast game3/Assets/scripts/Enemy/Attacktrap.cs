using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacktrap : MonoBehaviour
{ 
	public Animator animator; 

	public Transform attackPoint;  
	public LayerMask enemyLayers; 

	public float attackRange = 0.5f;
	public int attackDamage = 100; 

	public float attackRate = 2f; 
	float nextAttackTime = 0f; 

    public AudioClip collectedClip;
   
    // Update is called once per frame
    void Update()
    { 
        
    }  

     public void OnTriggerEnter2D(Collider2D collision) 
     {
     	if (collision.tag == "enemy")
    	{
    	
    			Attack(); 
                Sound();
    	
    	}
     }

    void Attack() 
    {
    	// Play an attack animation  
    	animator.SetTrigger("Attack");

    	//Detect enemies in range of attack 
    	Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

		// Damage them 
		foreach(Collider2D enemy in hitEnemies) 
		{
			enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
		} 

    }  

    void Sound()
    {
        PlayerController controller = GetComponent<PlayerController>(); 

        
         
            { 
                
                controller.PlaySound(collectedClip); 
                                        

            } 
        
    }

     


    void OnDrawGizmosSelected() 
    { 
    	if (attackPoint == null)
    	return;

    	Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}