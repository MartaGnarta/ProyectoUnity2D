using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public static PauseMenu instance;

    private void Awake()
    {
        instance = this;
    }

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

        if (pauseActive)
        {
            pauseGame();
        }
        else
        {
            resumeGame();
        }

        menu.SetActive(pauseActive);
        
    }

    public void setFalseTrue()
    {
        pauseActive ^= true;        
    }

    public void pauseGame()
    {            
        Time.timeScale = 0;

    }

    public void resumeGame()
    {
        Time.timeScale = 1;
    }
}
