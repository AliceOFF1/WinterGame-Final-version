using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    int currentHealth;
    private Material matBlink;
    private Material matDefault;
    private SpriteRenderer spriteRend;
    public GameObject objectToSpawn;
    public GameObject remouve;
    public GameObject E;
    public GameObject Message;

    AudioSource audioSource;

    public AudioClip collectedClipOn;


    private UnityEngine.Object explosion;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        currentHealth = maxHealth;

        explosion = Resources.Load("Explosion");

        spriteRend = GetComponent<SpriteRenderer>();

        matBlink = Resources.Load("PlayerBlink", typeof(Material)) as Material;
        matDefault = spriteRend.material;

        objectToSpawn.SetActive(false);
    }


    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
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

    void OnCollisionEnter2D(Collision2D other)
    {

        PlayerController controller = other.gameObject.GetComponent<PlayerController>();

        if (controller != null)

        {
            controller.ChangeHealth(-7);
        }
    }



    void Die()
    {

        // Die animation 
        animator.SetBool("IsDead", true);

        //Disable the enemy
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

        GameObject explosionRef = (GameObject)Instantiate(explosion);
        explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Destroy(E);
        Destroy(Message);
        Destroy(remouve, 0.01f);
        objectToSpawn.SetActive(true);
    }

}