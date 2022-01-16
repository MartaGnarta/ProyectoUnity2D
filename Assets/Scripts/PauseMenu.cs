using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public bool pauseActive;
    public GameObject menu;

    private GameManager _gameManager;

    private void Start()
    {
        pauseActive = false;
    }

    public void DrawMenu()
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
    }

    public void pauseGame()
    {
        if (pauseActive)
        {

        }
    }
}
