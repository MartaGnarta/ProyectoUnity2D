using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ButtonScene : MonoBehaviour
{
    public void loadMainmenu()
    {
        GC.Collect();
        PauseMenu.instance.resumeGame();
        SceneManager.LoadScene(0);        
    }

    public void loadGame()
    {
        GC.Collect();
        SceneManager.LoadScene(1);
    }

    public void loadCredits()
    {
        SceneManager.LoadScene(2);
    }

    public void loadMainmenuFromCredits()
    {
        SceneManager.LoadScene(0);
    }
}
