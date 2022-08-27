using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrampusRun : StateMachineBehaviour 
{  
	public float speed = 2.5f; 
    public float attackRange = 3f;

	Transform player; 
	Rigidbody2D rb; 
    Crampus crampus;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
    	player = GameObject.FindGameObjectWithTag("Player").transform; 
    	rb = animator.GetComponent<Rigidbody2D>(); 
        crampus = animator.GetComponent<Crampus>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
    {   
        crampus.LookAtPlayer();

    	Vector2 target = new Vector2(player.position.x, rb.position.y); 
    	Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime); 
    	rb.MovePosition(newPos); 

        if (Vector2.Distance(player.position, rb.position) <= attackRange) 
        {
            animator.SetTrigger("Attack");
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
    	animator.ResetTrigger("Attack");
    }
}
