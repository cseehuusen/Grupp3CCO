using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEnd : MonoBehaviour
{
    private bool hasHitBefore = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "EnemyDT" && collision.tag != "Player")
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null && hasHitBefore == false)
            {
                enemy.TakeDamage(100);
            }
            Enemy2 enemy2 = collision.GetComponent<Enemy2>();
            if (enemy2 != null && hasHitBefore == false)
            {
                enemy2.TakeDamage(100);
            }

            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, Time.maximumDeltaTime);
            hasHitBefore = true;
        }
    }
}
