using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
	[SerializeField] private FireType fireType; 

	public enum FireType 
	{
		Red, 
		Green, 
		Blue
	} 

	public FireType GetFireType() 
	{
		return fireType;
	} 

}
