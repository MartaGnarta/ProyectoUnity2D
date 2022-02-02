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

    public GameObject getSeed()
    {
        if (_uiInventory.activeItem().itemState == SetItem.ItemState.seed)
        {
            return _uiInventory.activeItem().GetItem();
        }
        else
        {
            return null;
        }        

    }

    public void useItem()
    {
        _uiInventory.activeItem().amount -= 1;
        refreshInventoryUI();
    }

    public void refreshInventoryUI()
    {
        _uiInventory.SetInventory(inventory);
    }
}
