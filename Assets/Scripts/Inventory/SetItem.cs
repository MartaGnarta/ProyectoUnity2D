using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetItem
{
    public enum ItemType
    {
        Beet,
        Eggplant,
        Potato,
        Tomato,
        TomatoSeed,
        BeetSeed,
        PotatoSeed,
        EggplantSeed,
    }

    public enum ItemState
    {
        seed,
        fruit,
        toUse,
    }

    public int index;
    public int price;
    public ItemType itemType;
    public ItemState itemState;
    public int amount;
    public bool active;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Tomato:
                return SetItemAssets.Instance.item[3];
            case ItemType.Beet:
                return SetItemAssets.Instance.item[0];
            case ItemType.Potato:
                return SetItemAssets.Instance.item[2];
            case ItemType.Eggplant:
                return SetItemAssets.Instance.item[1];
            case ItemType.TomatoSeed:
                return SetItemAssets.Instance.item[7];
            case ItemType.BeetSeed:
                return SetItemAssets.Instance.item[4];
            case ItemType.PotatoSeed:
                return SetItemAssets.Instance.item[6];
            case ItemType.EggplantSeed:
                return SetItemAssets.Instance.item[5];
        }
    }

    public PlantScriptableObject GetItem()
    {
        switch (itemType)
        {
            default:
            case ItemType.TomatoSeed:
                return SetItemAssets.Instance.plantScriptableObjects[3];
            case ItemType.BeetSeed:
                return SetItemAssets.Instance.plantScriptableObjects[0];
            case ItemType.PotatoSeed:
                return SetItemAssets.Instance.plantScriptableObjects[2];
            case ItemType.EggplantSeed:
                return SetItemAssets.Instance.plantScriptableObjects[1];
        }
    }

    //public override string ToString()
    //{
    //    return base.ToString() + "N: " + itemType.ToString() + "I: " + index.ToString() + "ACT: " + active.ToString() + "AM: " + amount.ToString();
    //}
}

