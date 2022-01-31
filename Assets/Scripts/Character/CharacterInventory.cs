using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInventory : MonoBehaviour
{
    private SetInventory inventory;
    [SerializeField]
    private Update_InventoryUI _uiInventory;

    private void Start()
    {
        inventory = new SetInventory();
        _uiInventory.SetInventory(inventory);       

    }

    public void AddItemActive()
    {
        //foreach (SetItem item in inventory.GetItemList())
        //{
        //    if ()
        //}
    }
}
