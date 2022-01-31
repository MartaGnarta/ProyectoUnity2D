using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInventory 
{
    private List<SetItem> itemList;

    public SetInventory()
    {
        itemList = new List<SetItem>();

        AddItem(new SetItem { itemType = SetItem.ItemType.Beet, index = 0, amount = 0, active = false });
        AddItem(new SetItem { itemType = SetItem.ItemType.Eggplant, index = 1, amount = 0, active = false });
        AddItem(new SetItem { itemType = SetItem.ItemType.Potato, index = 2, amount = 0, active = false });
        AddItem(new SetItem { itemType = SetItem.ItemType.Tomato, index = 3, amount = 0, active = false });

        AddItem(new SetItem { itemType = SetItem.ItemType.BeetSeed, index = 4, amount = 0, active = true });
        AddItem(new SetItem { itemType = SetItem.ItemType.EggplantSeed, index = 5, amount = 0, active = false });
        AddItem(new SetItem { itemType = SetItem.ItemType.PotatoSeed, index = 6, amount = 0, active = false });
        AddItem(new SetItem { itemType = SetItem.ItemType.TomatoSeed, index = 7, amount = 0, active = false });

        Debug.Log(itemList.Count);
    }

    public void AddItem(SetItem item)
    {       
        //foreach (SetItem inventoryItem in itemList)
        //{
        //    if (inventoryItem.itemType == item.itemType)
        //    {
        //        inventoryItem.amount += item.amount;
        //        inventoryItem.active = true;
        //    }
        //    else
        //    {
                
        //    }
        //}
        itemList.Add(item);
        //Debug.Log(itemList.Count);
    }


    public List<SetItem> GetItemList()
    {
        return itemList;
    }
}

//public int GetActiveItemIndex()
//{       
//    SetItem result = itemList.Find(
//        delegate (SetItem it)
//        {
//            return it.active == true;
//        }
//        );
//        if (result != null)
//        {
//            return result.index;
//        }
//        else
//        {
//            return 0;
//        }
//}

//public void GetActiveDisabled(int fruitI)
//{
//    itemList.Find(x => x.index == fruitI).active = true;
//    //Debug.Log("Activa: " + itemList.Find(x => x.index == fruitI).itemType);
//}