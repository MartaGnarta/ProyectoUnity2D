using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    private SetInventory inventory;
    private Update_InventoryUI uiInventory;

    private void Start()
    {
        inventory = new SetInventory();
        uiInventory = GetComponent<Update_InventoryUI>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //uiInventory.UpdateInventory();
            
            
        }
    }
    public void AddItemInventory(int index)
    {
        //AddItem(new SetItem { itemType = SetItem.ItemType.Beet, index = 0, amount = 0, active = false });

        uiInventory.UpdateInventory(index);
    }
}
