using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class WolfHealth : MonoBehaviour
{ 

	public int maxHealth = 100; 
	public int currentHealth;  
	public GameObject Wolf;
    private Material matBlink; 
    private Material matDefault; 
    private SpriteRenderer spriteRend; 
    public GameObject objectToSpawn;  

    AudioSource audioSource;
    
    public AudioClip collectedClipOn;  

    private UnityEngine.Object explosion; 

     [SerializeField] private AudioSource Sound;
    

    // Start is called before the first frame update
    void Start()
    { 
        currentHealth = maxHealth; 
       
        Wolf.SetActive(true);
        
        audioSource =GetComponent<AudioSource>();

        explosion = Resources.Load("Explosion"); 

        spriteRend = GetComponent<SpriteRenderer>();

        matBlink = Resources.Load("PlayerBlink", typeof(Material)) as Material;
       
        matDefault = spriteRend.material; 
    }  

    public void PlaySound(AudioClip clip) 
    {
      audioSource.PlayOneShot(collectedClipOn);
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
                controller.ChangeHealth(-25);  
            }  

        if (CompareTag("DieZone")) 
      {
         Die();
      }   
    }  

      public void TakeDamages(int damage) 
    {
        currentHealth -=damage; 

        {
          Sound.Play(); 
          spriteRend.material =matBlink; 
          Invoke("ResetMaterial", .2f); 
        }

        if(currentHealth <= 0) 
        { 
            Die();
        }  


    }   


    void Die()
    {

        GetComponent<Collider2D>().enabled = false; 
        this.enabled = false; 


        GameObject explosionRef = (GameObject)Instantiate(explosion); 
        explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);  
        Instantiate(objectToSpawn,transform.position, transform.rotation);
        Wolf.SetActive(false); 
    }

}
