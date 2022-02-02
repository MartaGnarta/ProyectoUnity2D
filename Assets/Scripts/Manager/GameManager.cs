using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private Update_InventoryUI _inventoryUI;
    private CinematicManager _cinematicManager;

    private void Start()
    {
        _inventoryUI = GetComponent<Update_InventoryUI>();
        _cinematicManager = GetComponent<CinematicManager>();
    }

    public bool isInventoryActive()
    {
        return _inventoryUI.iventoryActive;
    }
}
