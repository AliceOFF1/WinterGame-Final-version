using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTriggerAnim : MonoBehaviour
{
	[SerializeField] private GameObject doorGameObject;  
	private IDoor door;
	private float timer; 
	[SerializeField] 
	public GameObject objectToSpawn;
	public GameObject objectToSpawnForFire; 
	
	


   private void Start()
   {
   	objectToSpawn.SetActive(false); 
   	objectToSpawnForFire.SetActive(false);
   }
	

	private void Awake() 
	{
		door = doorGameObject.GetComponent<IDoor>();
	}  

	private void Update() 
	{
		if (timer >0) 
		{
			timer -= Time.deltaTime; 
			if(timer<=0f) 
			{
				door.CloseDoor();
			}
		} 

		
	} 



		void OnCollisionEnter2D (Collision2D coll)
   {
      if(coll.gameObject.tag =="fire") 
      {
         door.OpenDoor();
         StartCoroutine(DoDestroy());
         Destroy(gameObject);

      } 
			
	}  

	private void OnTriggerStay2D(Collider2D collider) 
	{

		if(collider.GetComponent<WoodController>() !=null) 
		{
			// Player still on top of collider! 
			timer = 0.1f;
		}
	}  

	 IEnumerator DoDestroy() 
   {
      objectToSpawn.SetActive(true); 
      objectToSpawnForFire.SetActive(true);
      yield return new WaitForSeconds(0.2f); 
      objectToSpawn.SetActive(false); 
     
   }


}
