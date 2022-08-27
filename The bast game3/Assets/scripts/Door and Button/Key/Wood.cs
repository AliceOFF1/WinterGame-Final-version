using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
	[SerializeField] private WoodType woodType; 

	public enum WoodType 
	{
		Red, 
		Green, 
		Blue
	} 

	public WoodType GetWoodType() 
	{
		return woodType;
	} 

}
