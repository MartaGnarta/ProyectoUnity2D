using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    private Inventory inventory;

    [SerializeField]
    private UI_Inventory uiInventory;

    private void Start()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }

    private void Update()
    {
        
    }

    public void InventoryActive(int fruitNum)
    {
        Item result = inventory.GetItemList().Find(
            delegate (Item it)
            {
                return it.index == fruitNum;
            }
            );
            if (result != null)
            {
                Debug.Log("Activo: " + result.itemType);
                result.active = true;
            }
            else
            {
                Debug.Log("Activo2: " + result.itemType);
                result.active = false;
            }
    }
}
