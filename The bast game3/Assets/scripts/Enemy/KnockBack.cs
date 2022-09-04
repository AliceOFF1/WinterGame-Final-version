using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    public float thrust;
    public float KnockTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Rigidbody2D enemy = other.GetComponent<Rigidbody2D>();
            if (enemy != null)
            {
                enemy.isKinematic = false;
                Vector2 difference = enemy.transform.position - transform.position;
                enemy.AddForce(difference, ForceMode2D.Impulse);
                StartCoroutine(KnockCo(enemy));
            }
        }
    }

    private IEnumerator KnockCo(Rigidbody2D enemy)
    {
        if (enemy != null)
        {
            yield return new WaitForSeconds(KnockTime);
            enemy.velocity = Vector2.zero;
            enemy.isKinematic = true;
        }
    }
}
