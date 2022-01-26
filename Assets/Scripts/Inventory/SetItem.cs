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

    public GameObject GetItem()
    {
        switch (itemType)
        {
            default:
            case ItemType.TomatoSeed:
                return SetItemAssets.Instance.prefabs[0];
            case ItemType.BeetSeed:
                return SetItemAssets.Instance.prefabs[1];
            case ItemType.PotatoSeed:
                return SetItemAssets.Instance.prefabs[2];
            case ItemType.EggplantSeed:
                return SetItemAssets.Instance.prefabs[3];
        }
    }
}

