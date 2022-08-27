using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyantenna : MonoBehaviour
{
	[SerializeField] private KeyantennaType keyantennaType;  

	public enum KeyantennaType 
	{
		Red, 
		Green, 
		Blue
	} 

	public KeyantennaType GetKeyantennaType() 
	{
		return keyantennaType;
	} 

   
}
