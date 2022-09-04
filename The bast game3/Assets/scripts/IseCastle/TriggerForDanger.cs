using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class TriggerForDanger : MonoBehaviour
{

    public GameObject Ise;
    public GameObject Particle;

    [SerializeField] private AudioSource Sound;
    // Start is called before the first frame update
    void Start()
    {
        Ise.SetActive(false);
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
        Particle.SetActive(true);
        Ise.SetActive(true);
        Sound.Play();
    }

}
