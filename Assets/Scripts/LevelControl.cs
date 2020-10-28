using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{

    public string levelName;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            //Loading level with build levelName
            SceneManager.LoadScene(levelName);

            //Restart level
            //SceneManager.LoaddScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
