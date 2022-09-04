using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotZoneCheck : MonoBehaviour
{
    private WolfEnemy enemyParent;
    private bool inRange;
    private Animator anim;

    private void Awake()
    {
        enemyParent = GetComponentInParent<WolfEnemy>();
        anim = GetComponentInParent<Animator>();
    }

    private void Update()
    {
        if (inRange && !anim.GetCurrentAnimatorStateInfo(0).IsName("WolfIdle"))
        {
            enemyParent.Flip();
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            inRange = true;
        }

        if (collider.gameObject.CompareTag("EnemyEat"))
        {
            inRange = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            inRange = false;
            gameObject.SetActive(false);
            enemyParent.triggerArea.SetActive(true);
            enemyParent.inRange = false;
            enemyParent.SelectTarget();
        }

        if (collider.gameObject.CompareTag("EnemyEat"))
        {
            inRange = false;
            gameObject.SetActive(false);
            enemyParent.triggerArea.SetActive(true);
            enemyParent.inRange = false;
            enemyParent.SelectTarget();
        }
    }


}


