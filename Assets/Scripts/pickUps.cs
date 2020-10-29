using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUps : MonoBehaviour
{
    private string Itemname;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Itemname = gameObject.name;
        switch (Itemname)
        {
            case "pills":
                Data.Medicine = 1;
                break;

            case "toiletpaper":
                Data.TP = 1;
                break;
            case "ammo":
                Data.Ammo = 1;
                break;
            default:
                Debug.Log("This should not happen");
                break;
        }
        Destroy(gameObject);


    }
}
