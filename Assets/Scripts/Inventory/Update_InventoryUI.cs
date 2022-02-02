using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Update_InventoryUI : MonoBehaviour
{
    private SetInventory inventory;
    public Transform inventorySlot;
    public bool iventoryActive;
    public Sprite noItem;

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
            if (itemA.active && itemA.amount > 0)
            {
                inventorySlot.gameObject.SetActive(true);
                inventorySlot.GetComponent<Image>().sprite = itemA.GetSprite();                
            }
            else
            {
                inventorySlot.GetComponent<Image>().sprite = noItem;
            }
        }

        
    }

    public SetItem activeItem()
    {
        foreach (SetItem itemA in inventory.GetItemList())
        {
            if (itemA.active && itemA.amount > 0)
            {
                return itemA;
            }            
        }
        return null;
    }
}
