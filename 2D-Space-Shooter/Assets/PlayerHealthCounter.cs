using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//bring the player health script into this script
using UnityEngine.UI;

//make a variable for the player health

public class PlayerHealthCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         //get player health component and console log the current health
        PlayerHealth playerHealth = GetComponent<Player>().Health;
        Debug.Log("Player health is " + playerHealth.CurrentHealth);
        
     

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
