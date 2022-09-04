using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;
    public LayerMask wolfLayers;

    public float attackRange = 0.5f;
    public int attackDamage = 40;

    public float attackRate = 2f;
    float nextAttackTime = 1f;

    public AudioClip collectedClip;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Attacks();
                Sound();
            }
        }

    }

    void Attacks()
    {
        // Play an attack animation  
        animator.SetTrigger("Attacks");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(20);
        }

        Collider2D[] hitWolf = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, wolfLayers);

        foreach (Collider2D wolf in hitWolf)
        {
            wolf.GetComponent<WolfHealth>().TakeDamages(20);
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
