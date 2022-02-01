using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public bool pauseActive;
    public GameObject menu;

    private void Start()
    {
        pauseActive = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            setFalseTrue();
        }
    }

    public void setFalseTrue()
    {       
        pauseActive ^= true;
        menu.SetActive(pauseActive);
        pauseGame();
    }

    public void pauseGame()
    {
        if (pauseActive)
        {            
            Time.timeScale = 0;
        }   
        else
        {            
            Time.timeScale = 1;
        }
    }
}
