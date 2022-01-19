using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScene : MonoBehaviour
{
    public int index;

    public Button button;

    private bool load;

    private void Start()
    {
        load = false;
        button.onClick.AddListener(buttonPressed);
    }

    private void Update()
    {        
        if (load)
        {
            SceneManager.LoadScene(index);
            load = false;
        }        
    }

    public void buttonPressed()
    {
        load = true;        
    }
}
