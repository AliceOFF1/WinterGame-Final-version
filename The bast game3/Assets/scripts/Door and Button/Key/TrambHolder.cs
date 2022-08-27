using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrambHolder : MonoBehaviour
{
    public event EventHandler OnTrambsChanged;
    private List<Tramb.TrambType> trambList; 

    private void Awake() 
    {
    	trambList = new List<Tramb.TrambType>();
    }  

    public List<Tramb.TrambType> GetTrambList() 
    {
        return trambList;
    }

    public void AddTramb(Tramb.TrambType trambType) 
    { 
    	trambList.Add(trambType); 
        OnTrambsChanged?.Invoke(this, EventArgs.Empty);
    } 

    public void RemoveTramb(Tramb.TrambType trambType) 
    {
    	trambList.Remove(trambType);
        OnTrambsChanged?.Invoke(this, EventArgs.Empty);
    } 

    public bool ContainsTramb(Tramb.TrambType trambType) 
    {
    	return trambList.Contains(trambType);
    } 

    private void OnTriggerEnter2D(Collider2D collider) 
    {
    	Tramb tramb = collider.GetComponent<Tramb>(); 
    	if (tramb != null) 
    	{
    		AddTramb(tramb.GetTrambType()); 
    		Destroy(tramb.gameObject);
    	} 

    	TrambDoor trambDoor = collider.GetComponent<TrambDoor>(); 
    	if (trambDoor != null) 
    	{
    		if(ContainsTramb(trambDoor.GetTrambType())) 
    		{
    			// Currently hplding key to open thus door 
    			RemoveTramb(trambDoor.GetTrambType());
    			trambDoor.OpenDoor(); 

    		}
    	}
    }
}