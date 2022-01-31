using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private Update_InventoryUI _inventoryUI;

    private void Awake()
    {
        _inventoryUI = GetComponent<Update_InventoryUI>();
    }

    public bool isInventoryActive()
    {
        return _inventoryUI.iventoryActive;
    }
}
