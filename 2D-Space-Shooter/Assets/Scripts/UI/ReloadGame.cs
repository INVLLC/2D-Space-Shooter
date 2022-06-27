using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//import scene manager
using UnityEngine.SceneManagement;
public class ReloadGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
       
    {
    //make a function that reloads the game
    if (Input.GetKeyDown(KeyCode.R))
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
                
        

    }
}
