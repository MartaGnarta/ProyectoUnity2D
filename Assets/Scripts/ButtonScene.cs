using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScene : MonoBehaviour
{
    public int index;

    public Button button;

    private void Update()
    {
        button.onClick.AddListener(buttonPressed);
    }

    public void buttonPressed()
    {
        SceneManager.LoadScene(index);
    }
}
