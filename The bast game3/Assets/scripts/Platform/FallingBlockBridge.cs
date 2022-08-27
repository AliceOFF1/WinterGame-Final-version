using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBlockBridge : MonoBehaviour
{
	Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    } 

    private void OnCollisionEnter2D(Collision2D collision) 
    {
    	if (collision.gameObject.name.Equals("Player")) 
    	{
    		Invoke("FallPlatform", 0.1f); 
    		Destroy(gameObject, 0.2f);
    	}
    } 

    void FallPlatform() 
    {
    	rb.isKinematic = false;
    } 
}

