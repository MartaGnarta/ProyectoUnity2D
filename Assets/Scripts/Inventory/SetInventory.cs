using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInventory 
{
    private List<SetItem> itemList;

    public SetInventory()
    {
        itemList = new List<SetItem>();

        AddItem(new SetItem { itemType = SetItem.ItemType.Beet, itemState = SetItem.ItemState.fruit, index = 0, price = 115, amount = 0, active = false, shopItem = false });
        AddItem(new SetItem { itemType = SetItem.ItemType.Eggplant, itemState = SetItem.ItemState.fruit, index = 1, price = 95, amount = 0, active = false, shopItem = false });
        AddItem(new SetItem { itemType = SetItem.ItemType.Potato, itemState = SetItem.ItemState.fruit, index = 2, price = 85, amount = 0, active = false, shopItem = false });
        AddItem(new SetItem { itemType = SetItem.ItemType.Tomato, itemState = SetItem.ItemState.fruit, index = 3, price = 65, amount = 0, active = false, shopItem = false });

        AddItem(new SetItem { itemType = SetItem.ItemType.BeetSeed, itemState = SetItem.ItemState.seed, index = 4, price = 90, amount = 0, active = false, shopItem = true });
        AddItem(new SetItem { itemType = SetItem.ItemType.EggplantSeed, itemState = SetItem.ItemState.seed, index = 5, price = 70, amount = 0, active = false, shopItem = true });
        AddItem(new SetItem { itemType = SetItem.ItemType.PotatoSeed, itemState = SetItem.ItemState.seed, index = 6, price = 60, amount = 0, active = false, shopItem = true });
        AddItem(new SetItem { itemType = SetItem.ItemType.TomatoSeed, itemState = SetItem.ItemState.seed, index = 7, price = 40, amount = 1, active = true, shopItem = true });

        AddItem(new SetItem { itemType = SetItem.ItemType.Scarecrow, itemState = SetItem.ItemState.toUse, index = 8, price = 450, amount = 0, active = false, shopItem = true });
        AddItem(new SetItem { itemType = SetItem.ItemType.WateringCan, itemState = SetItem.ItemState.toUse, index = 9, price = 1000, amount = 0, active = false, shopItem = true });
        AddItem(new SetItem { itemType = SetItem.ItemType.Insecticide, itemState = SetItem.ItemState.toUse, index = 10, price = 50, amount = 0, active = false, shopItem = true });
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
