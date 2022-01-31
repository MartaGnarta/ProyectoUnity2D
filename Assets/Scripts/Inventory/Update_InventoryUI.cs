using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Update_InventoryUI : MonoBehaviour
{
    private SetInventory inventory;
    public Transform inventorySlot;

    private void Start()
    {
        inventorySlot.gameObject.SetActive(true);
    }

    public void UpdateInventory(int index)
    {
        foreach (SetItem item in inventory.GetItemList())
        {
            if (item.index == index)
            {
                Debug.Log(item.itemType);
                inventorySlot.GetComponent<Image>().sprite = item.GetSprite();
            }
        }        
    }
}
