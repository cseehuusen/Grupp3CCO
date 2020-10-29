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
        int samlat = ammo + pills + toiletpaper;

        switch (samlat)
        {
            case (0):
                GameOver.text = "GAME OVER!!! \n You brought a shotgun to a knife fight and got nowhere...";
                break;
            case (1):
                GameOver.text = "GAME OVER!!! \n You failed to collect all items needed for your survival";
                break;
            case (2):
                GameOver.text = "GAME OVER!!! \n You failed to collect all items needed for your survival";
                break;

        }

    }
}
