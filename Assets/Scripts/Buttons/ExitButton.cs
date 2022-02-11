using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public bool exitMenu;
    public GameObject menu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenExitMenu();
        }
        

    }
    public void OpenExitMenu()
    {
        exitMenu ^= true;
        menu.SetActive(exitMenu);
    }

    public void closeExitMenu()
    {
        menu.SetActive(false);
    }
    public void closeGame()
    {
        Application.Quit();
    }
}
