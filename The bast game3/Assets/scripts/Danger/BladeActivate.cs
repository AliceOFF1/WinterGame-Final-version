using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeActivate : MonoBehaviour
{

    public GameObject Particle;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        Particle.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Player"))
        {
            {
                ExplodeTheObject();
            }

        }
    }

    void ExplodeTheObject()
    {
        timer = 1f;
    }

    private void Update()
    {
        if (timer > 0)
        {
            Particle.SetActive(true);
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                Particle.SetActive(false);

            }
        }
    }

}

