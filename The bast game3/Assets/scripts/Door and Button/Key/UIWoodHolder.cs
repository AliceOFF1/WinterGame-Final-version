using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIWoodHolder : MonoBehaviour
{
    [SerializeField] private WoodHolder woodHolder; 

    private Transform containerwood; 
    private Transform woodTemplate; 

    private void Awake() 
    {
    	containerwood = transform.Find("containerwood"); 
    	woodTemplate = containerwood.Find("woodTemplate"); 
    	woodTemplate.gameObject.SetActive(false);
    	
    	
    }  

    private void Start() 
    {
    	woodHolder.OnWoodsChanged += WoodHolder_OnWoodsChanged;
    } 

    private void WoodHolder_OnWoodsChanged(object sender, System.EventArgs e) 
    {
    	UpdateVisual();
    }

    private void UpdateVisual() 
    { 
    	// Clean up old keys 
    	foreach (Transform child in containerwood) 
    	{
    		if(child == woodTemplate) continue; 
    		Destroy(child.gameObject);
    	}

    	// Instantiate current key list
    	List<Wood.WoodType> woodList = woodHolder.GetWoodList(); 
    	for(int i = 0; i < woodList.Count; i++) 
    	{
    		Wood.WoodType woodType = woodList[i]; 
    		Transform woodTransform = Instantiate(woodTemplate, containerwood); 
    		woodTransform.gameObject.SetActive(true);
    		woodTransform.GetComponent<RectTransform>().anchoredPosition = new Vector2(50 * i, 0); 
    		Image woodImage = woodTransform.Find("image").GetComponent<Image>();  
    	
    	}
    }
}
