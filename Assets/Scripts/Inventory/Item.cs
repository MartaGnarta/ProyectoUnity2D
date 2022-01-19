using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item { 
    public enum ItemType
    {
        Tomato,
        Beet,
        Potato,
        Eggplant,
        TomatoSeed,
        BeetSeed,
        PotatoSeed,
        EggplantSeed,
    }

    public ItemType itemType;
    public int amount;
    public int index;
    public bool active;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Tomato: 
                return ItemAssets.Instance.tomato;
            case ItemType.Beet: 
                return ItemAssets.Instance.beet;
            case ItemType.Potato: 
                return ItemAssets.Instance.potato;
            case ItemType.Eggplant: 
                return ItemAssets.Instance.eggplant;
            case ItemType.TomatoSeed:
                return ItemAssets.Instance.tomatoSeed;
            case ItemType.BeetSeed:
                return ItemAssets.Instance.beetSeed;
            case ItemType.PotatoSeed:
                return ItemAssets.Instance.potatoSeed;
            case ItemType.EggplantSeed:
                return ItemAssets.Instance.eggplantSeed;
        }
    }

    public bool IsStackable()
    {
        switch (itemType)
        {
            default:
            case ItemType.Tomato:
            case ItemType.Beet:
            case ItemType.Potato:
            case ItemType.Eggplant:
                return true;
        }
    }
}
