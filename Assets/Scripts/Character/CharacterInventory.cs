using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInventory : MonoBehaviour
{
    private SetInventory inventory;
    [SerializeField]
    private Update_InventoryUI _uiInventory;
    private PlantSystem launcher;
    public GameObject plantPrefab;

    private void Start()
    {
        inventory = new SetInventory();
        _uiInventory.SetInventory(inventory);
        launcher = GetComponent<PlantSystem>();
    }

    public GameObject getSeed()
    {        
        if (activeItem().itemState == SetItem.ItemState.seed)
        {
            plantPrefab.GetComponent<GrowingSystem>().plantData = activeItem().GetItem();
            return plantPrefab;
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

    public void addItem(string name)
    {     
        foreach (SetItem item in inventory.GetItemList())
        {
            if (item.itemType.ToString().ToLower() == name.ToLower())
            {
                inventory.SetActivityTrueItem(item);
                inventory.IncreseAmountItem(item);
            }              
        }        

        refreshInventoryUI();
    }

    public int getList(int index)
    {
        foreach (SetItem item in inventory.GetItemList())
        {
            if (item.shopItem && item.index == index)
            {
                return item.price;
            }
        }

        return 0;
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
