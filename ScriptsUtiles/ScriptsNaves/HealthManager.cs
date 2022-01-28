using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Text healthText;

    void OnEnable()
    {
        //PlayerSystem.UpdateText += UpdateHealth;
    }

    void OnDisable()
    {
        //PlayerSystem.UpdateText -= UpdateHealth;
    }

    void Start()
    {
        healthText.text = "Health: ";
    }

    private void UpdateHealth(int health)
    {
        healthText.text = "Health: " + health;
        Debug.Log("a");
    }
}
