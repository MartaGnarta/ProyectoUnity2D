using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    private SetInventory inventory;
    [SerializeField]
    private Update_InventoryUI uiInventory;

    private void Awake()
    {
        inventory = new SetInventory();
    }

    public void prueba()
    {
        inventory.GetActiveDisabled(3);
    }
}
