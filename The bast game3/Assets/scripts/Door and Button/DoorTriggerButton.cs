using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
  [SerializeField] private GameObject doorGameObjectA; 
  [SerializeField] private GameObject doorGameObjectB;
  [SerializeField] private GameObject doorGameObjectC; 

  private IDoor doorA;
  private IDoor doorB;
  private IDoor doorC; 

  private void Awake() 
  {
    doorA = doorGameObjectA.GetComponent<IDoor>();
    doorB = doorGameObjectB.GetComponent<IDoor>();
    doorC = doorGameObjectC.GetComponent<IDoor>();
  }

  private void Update() 
  {
  	//if (Input.GetKeyDown(KeyCode.Z)) 
  	//{
  	//	doorA.OpenDoor();
  	//} 
  	//if (Input. GetKeyDown(KeyCode.X)) 
  	//{
  	//	doorA.CloseDoor();
  	//} 
  	if (Input.GetKeyDown(KeyCode.C)) 
  	{
  		doorB.OpenDoor();
  	} 
  	if (Input. GetKeyDown(KeyCode.V)) 
  	{
  		doorB.CloseDoor();
  	} 
  	if (Input.GetKeyDown(KeyCode.B)) 
  	{
  		doorC.OpenDoor();
  	} 
  	if (Input. GetKeyDown(KeyCode.N)) 
  	{
  		doorC.CloseDoor();
  	}
  }
}
