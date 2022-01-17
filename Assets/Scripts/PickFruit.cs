using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickFruit : MonoBehaviour
{
    public int index;
    public GameObject[] items;

    public bool picked;

    public void AddFruitInventory()
    {
        if (picked)
        {
            items[index].SetActive(true);
        }
    }
}
