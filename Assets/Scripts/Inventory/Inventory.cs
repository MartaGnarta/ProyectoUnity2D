using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.BeetSeed, index = 0, amount = 0, active = false });
        AddItem(new Item { itemType = Item.ItemType.EggplantSeed, index = 1, amount = 0, active = false });
        AddItem(new Item { itemType = Item.ItemType.PotatoSeed, index = 2, amount = 0, active = false });
        AddItem(new Item { itemType = Item.ItemType.TomatoSeed, index = 3, amount = 0, active = false });

        AddItem(new Item { itemType = Item.ItemType.Beet, index = 4, amount = 0, active = false });
        AddItem(new Item { itemType = Item.ItemType.Eggplant, index = 5, amount = 0, active = false });        
        AddItem(new Item { itemType = Item.ItemType.Potato, index = 6, amount = 0, active = false });
        AddItem(new Item { itemType = Item.ItemType.Tomato, index = 7, amount = 0, active = false });

        Debug.Log(itemList.Count);
    }

    public void AddItem(Item item)
    {
        //if (item.IsStackable())
        //{
        //    foreach (Item inventoryItem in itemList)
        //    {
        //        if (inventoryItem.itemType == item.itemType)
        //        {
        //            inventoryItem.amount += item.amount;
        //            inventoryItem.active = true;
        //        }
        //    }
        //}
        //else
        //{
        //    itemList.Add(item);
        //}        

        itemList.Add(item);
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }
}
