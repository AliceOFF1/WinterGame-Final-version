using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUp : MonoBehaviour
{
	Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    } 

    private void OnTriggerEnter2D(Collider2D collision)  
    {
    	{	
    		Invoke("FallPlatform", 0.1f); 
   		}
    } 

    void FallPlatform() 
    {
    	rb.isKinematic = false;
    } 
}

