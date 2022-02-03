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
        UpdateInventory();
    }

    public void UpdateInventory()
    {
        iventoryActive = false;

        foreach (SetItem itemA in inventory.GetItemList())
        {           
            if (itemA.active && itemA.amount > 0)
            {
                inventorySlot.gameObject.SetActive(true);
                inventorySlot.GetComponent<Image>().sprite = itemA.GetSprite();
                break;
            }
            else
            {
                inventorySlot.GetComponent<Image>().sprite = noItem;
            }
        }        
    }
}
