using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyForHide : MonoBehaviour
{

    private float moveing;
    private float speed = 0.4f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveing = -1f;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 17f)
        {
            moveing = 1f;
        }
        else if (transform.position.x > 19f)
        {
            moveing = -1f;
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveing * speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            Debug.Log("Spoted");
        }
    }
}
