using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus2 : MonoBehaviour
{
    public string levelTwo;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void OnPlayButtonPressed()
    {
        if(levelTwo == "Level Two")
        {
            SceneManager.LoadScene(levelTwo);
        }
        else
        {
            Debug.Log("You stupid chis");
        }
    }
}
