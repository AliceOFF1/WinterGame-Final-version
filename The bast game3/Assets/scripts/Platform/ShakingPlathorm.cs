using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakingPlathorm : MonoBehaviour
{

    bool isShacking = false;
    float shake = 0.01f;
    Vector2 pos;




    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isShacking == true)
        {
            transform.position = pos + UnityEngine.Random.insideUnitCircle * shake;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Player"))
        {
            isShacking = true;

            Invoke("StopShaking", 2);
        }
    }

    void StopShaking()
    {
        isShacking = false;
        transform.position = pos;
    }
}
