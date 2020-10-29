using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WinOrLose : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            int pills = Data.Medicine;
            int toiletpaper = Data.TP;
            int ammo = Data.Ammo;
            int samlat = ammo + pills + toiletpaper;

            switch (samlat)
            {
                case (0):
                    SceneManager.LoadScene("GameOver");
                    break;
                case (1):
                    SceneManager.LoadScene("GameOver");
                    break;
                case (2):
                    SceneManager.LoadScene("GameOver");
                    break;
                case (3):
                    SceneManager.LoadScene("Victory");
                    break;
            }

        }
    }
}
