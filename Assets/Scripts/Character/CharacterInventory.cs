using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInventory : MonoBehaviour
{
    private SetInventory inventory;
    [SerializeField]
    private Update_InventoryUI _uiInventory;

    private void Start()
    {
        inventory = new SetInventory();
        _uiInventory.SetInventory(inventory);
    }

    public GameObject getSeed()
    {
        if (activeItem().itemState == SetItem.ItemState.seed)
        {
            return activeItem().GetItem();
        }
        else
        {
            return null;
        }       
    }

    public void useItem()
    {
        inventory.DecreseAmountItem(activeItem());
        inventory.SetActivityFalseItem(activeItem());
        refreshInventoryUI();
    }

    public void addItem(int index)
    {
        foreach (SetItem item in inventory.GetItemList())
        {
            if (item.index == index)
            {
                inventory.SetActivityTrueItem(item);
                inventory.IncreseAmountItem(item);
            }                

            Debug.Log("Cantidad del objeto" + item.itemType + " " + item.amount);
            Debug.Log("Actividad del objeto" + item.itemType + " " + item.active);
        }        

        refreshInventoryUI();
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

    public void refreshInventoryUI()
    {
        _uiInventory.SetInventory(inventory);
    }
}
