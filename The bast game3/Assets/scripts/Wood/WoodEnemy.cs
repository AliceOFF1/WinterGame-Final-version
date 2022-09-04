using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodEnemy : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    int currentHealth;
    private Material matBlink;
    private Material matDefault;
    private SpriteRenderer spriteRend;
    public GameObject objectToSpawn;
    private Rigidbody2D rb;


    private UnityEngine.Object explosion;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        explosion = Resources.Load("Explosion");

        spriteRend = GetComponent<SpriteRenderer>();

        matBlink = Resources.Load("PlayerBlink", typeof(Material)) as Material;
        matDefault = spriteRend.material;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;


        // Play hurt animation  

        {
            spriteRend.material = matBlink;
            Invoke("ResetMaterial", .2f);

        }


        if (currentHealth <= 0)
        {
            Die();
        }
    }



    void ResetMaterial()
    {
        spriteRend.material = matDefault;
    }



    void Die()
    {
        Debug.Log("Enemy died!");

        // Die animation 
        animator.SetBool("IsDead", true);

        //Disable the enemy
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

        GameObject explosionRef = (GameObject)Instantiate(explosion);
        explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(objectToSpawn, transform.position, transform.rotation);
        Destroy(gameObject, 0.2f);
    }

}
