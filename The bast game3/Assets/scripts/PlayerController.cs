using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
   public float speed; 
   public float jumpForce; 
   private float moveInput; 
   private Rigidbody2D rb; 
  
   public float maxHealth = 100; 
   public float maxFreazen = 10000; 
   public float maxEat = 100; 
   public float timeInvincible = 2.0f;  
   public float secondsToEmptyFood =60f;  
   public float upSpead;


   bool isDead = false;


   public float health { get {return currentHealth;} }
   public float freazen{ get {return currentFreazen;} } 
   public float eat{ get {return currentEat;} } 
   public float currentHealth;
   public float currentFreazen;
   public float currentEat;  
 
   bool isInvicible; 
   float invicibleTimer; 


    

   private bool isGrounded; 
   public Transform feetPos; 
   public float checkRadius; 
   public LayerMask whatIsGround; 
   

   private Animator anim; 
   public VectorValue pos; 

 
   AudioSource audioSource;   

   private Material matBlink; 
   private Material matDefault; 
   private SpriteRenderer spriteRend;  

   private SpriteRenderer rend; 

   private bool canHide = false; 
   private bool hiding = false;
   private bool isFishing = false;  
   private bool facingRight = true;  
   private bool DialogActivate = false;

   
   [SerializeField] 
   GameObject DestroyPoint; 
   [SerializeField] private AudioSource fightSound;
   [SerializeField] private AudioSource damageSound; 
   [SerializeField] private AudioSource jumpSound;








 





   private void Start() 
   {
         transform.position = pos.initialValue; 
         anim = GetComponent<Animator>();
         rb = GetComponent<Rigidbody2D>(); 

         currentHealth = maxHealth;
         currentFreazen = maxFreazen;
         currentEat = maxEat;  

         audioSource = GetComponent<AudioSource>(); 

         spriteRend = GetComponent<SpriteRenderer>();

         matBlink = Resources.Load("PlayerBlink", typeof(Material)) as Material;
         matDefault = spriteRend.material;  

         DestroyPoint.SetActive(false); 

         rend = GetComponent<SpriteRenderer>();  

       



   } 

   public void OnTriggerEnter2D(Collider2D collision) 
   {
      
     
      if(collision.gameObject.name.Equals("HideElement")) 
   		
   		{
   			canHide = true;
   		} 


   	  if(collision.gameObject.name.Equals("Fishing")) 
   		
   		{
   			isFishing = true; 
   		} 
  

      


   		if  (collision.CompareTag("NPS"))
   	 		{
         		NonPlayerCharacter character = collision.GetComponent<NonPlayerCharacter>();
         		if (character !=null)
         		{
         			character.DisplayDialog();
         		}
        	
         		
         	} 

        if (collision.CompareTag("obs")) 
      {
         spriteRend.material =matBlink; 
         Invoke("ResetMaterial", .2f);
      } 

       if (collision.CompareTag("DieZone")) 
      {
         ChangeHealth(-100);
      }   

      if (collision.CompareTag("ChekPoint")) 
      {
         SavePlayer();
      }  

    }  

    

    private void OnTriggerExit2D(Collider2D collision) 
   {
   		if(collision.gameObject.name.Equals("HideElement")) 
   		{
   			canHide = false; 
   		}  


   		 if(collision.gameObject.name.Equals("Fishing")) 
   		
   		{
   			isFishing = false; 
      	}  
 
   } 



   void ResetMaterial() 
   {
      spriteRend.material = matDefault;
   }


   private void FixedUpdate()
   {

     
      if(!CanMove()==true)
         return;   
      
         
         moveInput = Input.GetAxis("Horizontal");
         rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
         if(facingRight == false && moveInput >0)
         {
            Flip();
         }
         else if (facingRight == true && moveInput < 0)
         {
            Flip();
         } 
         if (moveInput == 0)
         {
            anim.SetBool("isRunning", false); 
         }
         else
         {
            anim.SetBool("isRunning", true); 
         } 

         if (isInvicible) 
         {
            
            if (invicibleTimer < 0) 
               isInvicible = false; 
         } 

         if(!hiding) 
         {
         	rb.velocity = new Vector2(moveInput, rb.velocity.y); 
         } 
         else 
         {
         	rb.velocity = Vector2.zero;
         }  


       

        




   }
   
   private void Update()
   { 

      if(!CanMove()==true)
         return; 
     
      if(isDead) 
         return;

      if (DialogueManager.isActive == true) 
         return;

      isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

      if(isGrounded == true && Input. GetKeyDown (KeyCode.Space))
      {
         rb.velocity = Vector2.up * jumpForce;
         anim.SetTrigger("takeOf");  
         jumpSound.Play();
      }  

      if(isGrounded)
      {
      	upSpead = 200f;
      }

      if(isGrounded == true) 
      {
         anim.SetBool("isJumping", false);
      }
      else 
      {
         anim.SetBool("isJumping", true);
      }  

      if (isInvicible) 
      {
         invicibleTimer -= Time.deltaTime; 
         if (invicibleTimer <0) 
            isInvicible =false;
      } 

       if (currentFreazen <=10000) 
          currentFreazen -= 40*Time.deltaTime ;
          UIFreazenBar.instance.SetValue(currentFreazen / (float)maxFreazen);
      
      if (currentFreazen <1) 
          currentHealth -= 100/secondsToEmptyFood*Time.deltaTime ;
          UIHealthBar.instance.SetValue(currentHealth / (float)maxHealth);

      if (currentEat <=100) 
          currentEat -= 10/secondsToEmptyFood*Time.deltaTime ;
          UIEatBar.instance.SetValue(currentEat / (float)maxEat);

      if (currentEat <1) 
          currentHealth -= 100/secondsToEmptyFood*Time.deltaTime ;
          UIHealthBar.instance.SetValue(currentHealth / (float)maxHealth);
      
      if (currentHealth<=0)
      {
         FindObjectOfType<PlayerController>().LoadPlayer();
      } 

      if(Input.GetKeyDown(KeyCode.Mouse0))  
      {
         StartCoroutine(DoDestroy());
      } 


      if (canHide == true && Input.GetKey(KeyCode.UpArrow)) 
      {
      	Physics2D.IgnoreLayerCollision(8,13, true); 
      	rend.sortingOrder = 10; 
      	hiding = true;
      } 


      else 
      {
      	Physics2D.IgnoreLayerCollision(8,13, false); 
      	rend.sortingOrder = 22; 
      	hiding = false;
      } 

   
    

      if (isFishing == true && Input. GetKeyDown (KeyCode.E))
         {
         	 anim.SetBool("isFishing", true); 
         } 
        else 
        {
        	
         	anim.SetBool("isFishing", false);
            
        }  

        
   }

   bool CanMove()
   {
      bool can = true; 


      if (isDead) 
         can = false;
         transform.position += new Vector3 (0,0,0) * speed * Time.deltaTime; 

      return can;

   } 

   


   public void ChangeHealth(float amount)  
   { 
      if (amount<0) 
      {
         if (isInvicible) 
            return; 

         isInvicible = true; 
         invicibleTimer = timeInvincible;
      }

      currentHealth = Mathf.Clamp (currentHealth + amount , 0, maxHealth); 
      UIHealthBar.instance.SetValue(currentHealth / (float)maxHealth);
      
       


   } 


    public void ChangeFreazen(float amount)  
   { 
      if (amount<0) 
      {
         if (isInvicible) 
            return; 

         isInvicible = true; 
         invicibleTimer = timeInvincible;
      }

      currentFreazen = Mathf.Clamp (currentFreazen + amount, 0, maxFreazen); 
      UIFreazenBar.instance.SetValue(currentFreazen / (float)maxFreazen);
     
   } 

    public void ChangeEat(float amount)  
   { 
      if (amount<0) 
      {
         if (isInvicible) 
            return; 

         isInvicible = true; 
         invicibleTimer = timeInvincible;
      }

      currentEat = Mathf.Clamp (currentEat + amount, 0, maxEat); 
      UIEatBar.instance.SetValue(currentEat / (float)maxEat);
       
   }   

   


   void Flip()
   {
      facingRight = !facingRight;
      Vector3 Scaler = transform.localScale;
      Scaler.x *= -1;
      transform.localScale = Scaler;
   } 

   void OnCollisionEnter2D (Collision2D coll)
   {
      if(coll.gameObject.tag =="elevator") 
      {
         transform.parent = coll.gameObject.transform;
      } 

      if(coll.gameObject.tag=="Mouving_platform") 
      {
      	transform.parent = coll.gameObject.transform;
      }   

      if(coll.gameObject.tag=="tramp" && isGrounded == false) 
      {
      	upSpead += 50f; 
      	rb.AddForce(new Vector2(0,upSpead)); 
      	if(upSpead >=300f)
      	{
      		upSpead = 300f;
      	}

      }   
   
   }

      void OnCollisionExit2D (Collision2D coll)
   {
      if(coll.gameObject.tag =="elevator") 
      {
         transform.parent = null;
      }  

      if(coll.gameObject.tag=="Mouving_platform") 
      {
      	transform.parent = null;
      }
       
   }  

    

   public void PlaySound(AudioClip clip) 
   {
      audioSource.PlayOneShot(clip);
   } 


   public void Die() 
   {
      isDead = true;
      FindObjectOfType<LavelManager>().Restart();
   }  

   IEnumerator DoDestroy() 
   {
      DestroyPoint.SetActive(true);
      yield return new WaitForSeconds(0.1f); 
      DestroyPoint.SetActive(false); 
     
   } 


   public void SavePlayer() 
   {
      SaveSystem.SavePlayerController(this); 
   } 

   public void LoadPlayer() 
   {
      PlayerData data = SaveSystem.LoadPlayer(); 

      currentHealth = data.currentHealth;
      currentFreazen = data.currentFreazen;
      currentEat = data.currentEat;  

      Vector3 position; 
      position.x = data.position[0]; 
      position.y = data.position[1]; 
      position.z = data.position[2]; 
      transform.position = position;  

    } 

    
}