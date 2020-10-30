using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectionTrigger2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "PlayerBullet")
        {
            Enemy2 detectionVar = GetComponentInParent<Enemy2>();
            detectionVar.detectPC = true;
        }


    }
}
