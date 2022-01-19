using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.Tomato, amount = 0, index = 0, active = false });
        AddItem(new Item { itemType = Item.ItemType.Potato, amount = 0, index = 1, active = false });
        AddItem(new Item { itemType = Item.ItemType.Beet, amount = 0, index = 2, active = false });
        AddItem(new Item { itemType = Item.ItemType.Eggplant, amount = 0, index = 3, active = false });
        AddItem(new Item { itemType = Item.ItemType.TomatoSeed, amount = 0, index = 4, active = false });
        AddItem(new Item { itemType = Item.ItemType.PotatoSeed, amount = 0, index = 5, active = false });
        AddItem(new Item { itemType = Item.ItemType.BeetSeed, amount = 0, index = 6, active = false });
        AddItem(new Item { itemType = Item.ItemType.EggplantSeed, amount = 0, index = 7, active = false });
        Debug.Log(itemList.Count);
    }

    public void AddItem(Item item)
    {      
        if (item.IsStackable())
        {
            foreach (Item inventoryItem in itemList)
            {
                if (inventoryItem.itemType == item.itemType)
                {
                    inventoryItem.amount += item.amount;
                    inventoryItem.active = true;
                }
            }
        }
        else
        {
            itemList.Add(item);
        }
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }
}
