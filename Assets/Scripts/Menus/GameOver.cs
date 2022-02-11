using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public bool gameOver = false;
    public GameObject menuGameOver;
    private GameObject[] Gobjects;
    private GameObject[] terrains;

    public GameObject endText;

    private void Start()
    {
        terrains = GameObject.FindGameObjectsWithTag("terrain");        
    }

    private void Update()
    {
        Gobjects = GameObject.FindGameObjectsWithTag("plantDeath");
        endText.GetComponent<Text>().text = "Total Money: " + MoneyManager.instance.activeMoney.ToString();

        if (gameOver)
        {
            PauseMenu.instance.pauseGame();
            openGameOver();
        }        

        if (Gobjects.Length == terrains.Length)
        {
            gameOver = true;
        }

    }

    public void openGameOver()
    {
        menuGameOver.SetActive(true);
    }
}
