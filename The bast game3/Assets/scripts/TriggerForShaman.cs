using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForShaman : MonoBehaviour
{
    public GameObject SummerLayer;
    public GameObject ShamanLayer;
    public float timer;
    private bool Activate;



    void Start()
    {
        ShamanLayer.SetActive(true);
        SummerLayer.SetActive(false);
        Activate = false;
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))

        {
            timer = 0.0001f;
            Activate = true;
        }
    }

    private void Update()
    {
        if (timer > 0 && Activate == true && Input.GetKeyDown(KeyCode.X))
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                ShamanLayer.SetActive(false);
                SummerLayer.SetActive(true);
            }
        }
    }

}


