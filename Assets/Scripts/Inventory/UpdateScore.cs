using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{  
    public void RefreshScore()
    {       
        var current = MoneyManager.instance.activeMoney;
        gameObject.GetComponent<Text>().text = current.ToString();
    }
}
