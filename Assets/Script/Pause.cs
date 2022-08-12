using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool ispaused = false;
    public void PauseGame()
    {
        if (ispaused)
        {
            Time.timeScale = 1;
            ispaused = false;
        }
        else
        {
            Time.timeScale = 0;
            ispaused = true;
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
