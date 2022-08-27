using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodHolder : MonoBehaviour 
{
    public event EventHandler OnWoodsChanged;
    private List<Wood.WoodType> woodList; 

    private void Awake() 
    {
    	woodList = new List<Wood.WoodType>();
    }  

    public List<Wood.WoodType> GetWoodList() 
    {
        return woodList;
    }

    public void AddWood(Wood.WoodType woodType) 
    { 
    	woodList.Add(woodType); 
        OnWoodsChanged?.Invoke(this, EventArgs.Empty);
    } 

    public void RemoveWood(Wood.WoodType woodType) 
    {
    	woodList.Remove(woodType);
        OnWoodsChanged?.Invoke(this, EventArgs.Empty);
    } 

    public bool ContainsWood(Wood.WoodType woodType) 
    {
    	return woodList.Contains(woodType);
    } 

    private void OnTriggerEnter2D(Collider2D collider) 
    {
    	Wood wood = collider.GetComponent<Wood>(); 
    	if (wood != null) 
    	{
    		AddWood(wood.GetWoodType()); 
    		Destroy(wood.gameObject);
    	} 

    	WoodDoor woodDoor = collider.GetComponent<WoodDoor>(); 
    	if (woodDoor != null) 
    	{
    		if(ContainsWood(woodDoor.GetWoodType())) 
    		{
    			// Currently hplding key to open thus door 
    			RemoveWood(woodDoor.GetWoodType());
    			woodDoor.OpenDoor(); 

    		}
    	}

        
    }
}
