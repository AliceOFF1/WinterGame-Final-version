using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFireHolder : MonoBehaviour
{
    [SerializeField] private FireHolder fireHolder; 

    private Transform containerfire; 
    private Transform fireTemplate; 

    private void Awake() 
    {
    	containerfire = transform.Find("containerfire"); 
    	fireTemplate = containerfire.Find("fireTemplate"); 
    	fireTemplate.gameObject.SetActive(false);
    	
    	
    }  

    private void Start() 
    {
    	fireHolder.OnFiresChanged += FireHolder_OnFiresChanged;
    } 

    private void FireHolder_OnFiresChanged(object sender, System.EventArgs e) 
    {
    	UpdateVisual();
    }

    private void UpdateVisual() 
    { 
    	// Clean up old keys 
    	foreach (Transform child in containerfire) 
    	{
    		if(child == fireTemplate) continue; 
    		Destroy(child.gameObject);
    	}

    	// Instantiate current key list
    	List<Fire.FireType> fireList = fireHolder.GetFireList(); 
    	for(int i = 0; i < fireList.Count; i++) 
    	{
    		Fire.FireType fireType = fireList[i]; 
    		Transform fireTransform = Instantiate(fireTemplate, containerfire); 
    		fireTransform.gameObject.SetActive(true);
    		fireTransform.GetComponent<RectTransform>().anchoredPosition = new Vector2(50 * i, 0); 
    		Image fireImage = fireTransform.Find("image").GetComponent<Image>();  
    	
    	}
    }
}
