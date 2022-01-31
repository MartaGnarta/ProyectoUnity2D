using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Update_InventoryUI : MonoBehaviour
{
    private SetInventory inventory;
    public Transform inventorySlot;
    public bool iventoryActive;

    public void SetInventory(SetInventory inventory)
    {
        this.inventory = inventory;
        Debug.Log(inventory);
        UpdateInventory();
    }

    public void UpdateInventory()
    {
        Debug.Log(inventory.GetItemList());

        iventoryActive = false;

        foreach (SetItem itemA in inventory.GetItemList())
        {
            if (itemA.active)
            {
                inventorySlot.gameObject.SetActive(true);
                inventorySlot.GetComponent<Image>().sprite = itemA.GetSprite();
                iventoryActive = true;
            }
        }
    }

    public bool IsinventoryActive()
    {
        return iventoryActive;
    }
}
