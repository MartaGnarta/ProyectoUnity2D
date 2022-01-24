using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;

    private void Start()
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotTemplate = itemSlotContainer.Find("itemSlotTemplate");
    }

    private void Update()
    {
        RefreshInventoryItems();
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems()
    {
        foreach (Item item in inventory.GetItemList())
        {
            RectTransform _itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();

            if (item.active)
            {
                _itemSlotRectTransform.gameObject.SetActive(true);
            }
            else
            {
                _itemSlotRectTransform.gameObject.SetActive(false);
            }
                     
            Image image = _itemSlotRectTransform.Find("image").GetComponent<Image>();
            image.sprite = item.GetSprite();
        }
    }
}


