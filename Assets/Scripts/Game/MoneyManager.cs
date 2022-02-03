using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;

    [SerializeField]
    private UpdateScore score;

    private void Awake()
    {
        instance = this;
        activeMoney = 0;
    }

    public bool negativeMoney;
    public int activeMoney;

    public void increseMoney(int fruitPrice)
    {
        activeMoney += fruitPrice;
        RefreshMoney();
    }

    public bool decreseMoney(int itemPrice)
    {
        if (activeMoney - itemPrice >= 0)
        {
            activeMoney -= itemPrice;
            RefreshMoney();

            return true;
        }
        else
        {
            return false;
        }
        
    }

    public void RefreshMoney()
    {
        score.RefreshScore();
    }
}
