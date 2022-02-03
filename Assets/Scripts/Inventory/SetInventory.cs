using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInventory 
{
    private List<SetItem> itemList;

    public SetInventory()
    {
        itemList = new List<SetItem>();

        AddItem(new SetItem { itemType = SetItem.ItemType.Beet, itemState = SetItem.ItemState.fruit, index = 0, price = 130, amount = 0, active = false });
        AddItem(new SetItem { itemType = SetItem.ItemType.Eggplant, itemState = SetItem.ItemState.fruit, index = 1, price = 110, amount = 0, active = false });
        AddItem(new SetItem { itemType = SetItem.ItemType.Potato, itemState = SetItem.ItemState.fruit, index = 2, price = 80, amount = 0, active = false });
        AddItem(new SetItem { itemType = SetItem.ItemType.Tomato, itemState = SetItem.ItemState.fruit, index = 3, price = 50, amount = 0, active = false });

        AddItem(new SetItem { itemType = SetItem.ItemType.BeetSeed, itemState = SetItem.ItemState.seed, index = 4, amount = 0, active = false });
        AddItem(new SetItem { itemType = SetItem.ItemType.EggplantSeed, itemState = SetItem.ItemState.seed, index = 5, amount = 1, active = true });
        AddItem(new SetItem { itemType = SetItem.ItemType.PotatoSeed, itemState = SetItem.ItemState.seed, index = 6, amount = 0, active = false });
        AddItem(new SetItem { itemType = SetItem.ItemType.TomatoSeed, itemState = SetItem.ItemState.seed, index = 7, amount = 0, active = false });
    }

    public void AddItem(SetItem item)
    {      
        itemList.Add(item);        
    }

    public void IncreseAmountItem(SetItem itemA)
    {
        foreach (SetItem item in itemList)
        {
            if (itemA == item)
            {
                itemA.amount++;
            }
        }        
    }

    public void DecreseAmountItem(SetItem itemA)
    {
        foreach (SetItem item in itemList)
        {
            if (itemA == item)
            {
                itemA.amount--;
            }
        }
    }

    public void SetActivityTrueItem(SetItem itemA)
    {
        foreach (SetItem item in itemList)
        {
            if (itemA == item)
            {
                itemA.active = true;
            }
        }
    }

    public void SetActivityFalseItem(SetItem itemA)
    {
        foreach (SetItem item in itemList)
        {
            if (itemA == item)
            {
                itemA.active = false;
            }
        }
    }

    public List<SetItem> GetItemList()
    {
        return itemList;
    }
}
