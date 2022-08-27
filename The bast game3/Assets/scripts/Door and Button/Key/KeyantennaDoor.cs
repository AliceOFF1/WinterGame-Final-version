using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyantennaDoor : MonoBehaviour
{
	[SerializeField] private Keyantenna.KeyantennaType keyantennaType;  

	private Animator animator; 
   	private bool isOpen = false; 
	public GameObject DialogKey;
	public GameObject BlockExitTrig;
	public GameObject messageTrig; 
	public GameObject messageTriger; 

	void Start()
	{
		DialogKey.SetActive(false);
		messageTriger.SetActive(true);
	} 

   	private void Awake() 
   {
   	animator = GetComponent<Animator>();
   } 

	public Keyantenna.KeyantennaType GetKeyantennaType() 
	{
		return keyantennaType;
	} 

	public void OpenDoor() 
	{
		isOpen = true;
		DialogKey.SetActive(true); 
        Destroy(BlockExitTrig);
        Destroy(messageTrig);
   		animator.SetBool("Antenna", true); 
   		messageTriger.SetActive(false);
	}

}
