using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoadButton : MonoBehaviour
{
  
    public void LoadLevelByName(string levelToLoadName)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(levelToLoadName);
    }

    //load scene "level 1"
    public void RetryGame()
    {
         Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }
}


