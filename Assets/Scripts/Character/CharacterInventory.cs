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

    public void AddItemInventory(int index)
    {
        //AddItem(new SetItem { itemType = SetItem.ItemType.Beet, index = 0, amount = 0, active = false });
        inventory.AddItem(new SetItem { itemType = SetItem.ItemType.Beet, index = 0, amount = 0, active = true });
    }
}
