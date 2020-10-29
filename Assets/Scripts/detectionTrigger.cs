using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectionTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Enemy detectionVar = GetComponentInParent<Enemy>();
            detectionVar.detectPC = true;
        }


    }
}
