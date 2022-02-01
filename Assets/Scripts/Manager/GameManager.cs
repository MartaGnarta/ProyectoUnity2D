using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private Update_InventoryUI _inventoryUI;

    public bool firstDialogue = false;

    private void Awake()
    {
        _inventoryUI = GetComponent<Update_InventoryUI>();

        if (!firstDialogue)
        {
            CinematicManager.OnTriggerCinematic();
        }
    }

    public bool isInventoryActive()
    {
        return _inventoryUI.iventoryActive;
    }
}
