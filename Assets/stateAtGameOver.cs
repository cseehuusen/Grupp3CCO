using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class stateAtGameOver : MonoBehaviour
{
    private TextMeshPro GameOver;
    // Start is called before the first frame update
    void Start()
    {
        GameOver = GetComponent<TextMeshPro>();
        int kills = Data.Kills;
        int pills = Data.Medicine;
        int toiletpaper = Data.TP;
        int ammo = Data.Ammo;

        switch (kills,pills,toiletpaper,ammo):
            case (kills == 0, pills == 0; toiletpaper ==0, ammo ==0):
        break;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
