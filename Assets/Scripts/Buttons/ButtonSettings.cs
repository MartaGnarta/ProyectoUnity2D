using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSettings : MonoBehaviour
{
    private bool pauseActive;
    public GameObject pauseMenu;

    public Button closeButton;

    private void Start()
    {
        pauseActive = false;
        Button button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(buttonPressed);
        closeButton.onClick.AddListener(closeMenu);
    }

    private void Update()
    {
        if (pauseActive)
        {            
            pauseMenu.SetActive(pauseActive);                
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            closeMenu();
        }
    }

    public void buttonPressed()
    {
        pauseActive = true;
    }

    public void closeMenu()
    {
        pauseActive = false;
        pauseMenu.SetActive(pauseActive);        
    }
}
