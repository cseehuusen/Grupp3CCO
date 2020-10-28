using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEnd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy !=null)
        {
            enemy.TakeDamage(100);
        }
        GetComponent<SpriteRenderer>().enabled = false;
        Destroy(gameObject, Time.maximumDeltaTime);
    }
}
