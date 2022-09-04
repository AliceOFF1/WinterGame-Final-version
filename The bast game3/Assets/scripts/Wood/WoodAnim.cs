using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodAnim : MonoBehaviour
{
    [SerializeField] private GameObject woodGameObject;
    private IWood wood;
    private float timer;

    private void Awake()
    {
        wood = woodGameObject.GetComponent<IWood>();
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                wood.FinishWood();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<DestroyPoint>() != null)
        {
            //Player entered collider! 
            wood.StartWood();
            timer = 0.45f;
        }
    }


}

