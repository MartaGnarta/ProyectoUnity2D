using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Update_InventoryUI : MonoBehaviour
{
    private SetInventory inventory;
    public Transform inventorySlot;

    private void Start()
    {
        inventorySlot.gameObject.SetActive(true);
    }
    public void Update()
    {
        //inventorySlot.GetComponent<Image>().sprite = SetItemAssets.Instance.item[inventory.GetActiveItemIndex()];
    }
}
