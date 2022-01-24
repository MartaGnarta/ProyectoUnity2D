using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item { 
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

    public int index;
    public ItemType itemType;
    public int amount;    
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

    public int GetPlantFruit()
    {
        switch (itemType)
        {
            default:
            case ItemType.Tomato:
                return index;
            case ItemType.Beet:
                return index; 
            case ItemType.Potato:
                return index; 
            case ItemType.Eggplant:
                return index;
        }
    }
}
