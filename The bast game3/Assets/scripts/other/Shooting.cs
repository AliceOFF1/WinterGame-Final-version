using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject shootingItem; 
    public Transform shootingPoint; 
    public bool canShoot = true; 
    public float timer; 



    void Shoot() 
    {
    	if(!canShoot) 
    	return; 

    	GameObject si = Instantiate(shootingItem, shootingPoint);
    	si.transform.parent = null;

        timer = 1f;
                 
    } 

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Mouse1)) 
        {
            Shoot(); 
            canShoot = false;
        }

        
        if (timer >0) 
        {
            timer -= Time.deltaTime; 
            if(timer<=0f) 
            {
                canShoot = true;
            }
        }
            
    } 




}
