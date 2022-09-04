using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntennaAndKey : MonoBehaviour
{
    private bool KeyActivate;
    public GameObject DialogKey;
    public GameObject BlockExitTrig;
    public GameObject messageTrig;

    void Start()
    {
        DialogKey.SetActive(false);
        KeyActivate = false;
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<KeyController>() != null)
        {
            //Player entered collider! 
            KeyActivate = true;
        }

    }


    void Update()
    {

        if (KeyActivate == true && Input.GetKey(KeyCode.E))
        {
            DialogKey.SetActive(true);
            Destroy(BlockExitTrig);
            Destroy(messageTrig);

        }

        if (KeyActivate == true && Input.GetKey(KeyCode.X))
        {
            DialogKey.SetActive(false);

        }
    }




}

