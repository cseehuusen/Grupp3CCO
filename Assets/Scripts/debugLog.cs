using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugLog : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Ammo = " + Data.Ammo);
        Debug.Log("TP = " + Data.TP);
        Debug.Log("Medicine = " + Data.Medicine);
    }
}
