using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShedManager : MonoBehaviour
{
    private SetInventory inventory;

    [SerializeField]
    private CharacterInventory _characterInventory;

    private void Start()
    {
        
    }

    // Falta actualizar dinero despues de compras.

    public void addBeetSeedItem()
    {
        if (_characterInventory.activeItem() == null && MoneyManager.instance.decreseMoney(100))
        {
            _characterInventory.addItem("BeetSeed");
        }
    }

    public void addEggplantSeedItem()
    {
        if (_characterInventory.activeItem() == null && MoneyManager.instance.decreseMoney(100))
        {
            _characterInventory.addItem("EggplantSeed");
        }
    }

    public void addPotatoSeedItem()
    {
        if (_characterInventory.activeItem() == null && MoneyManager.instance.decreseMoney(100))
        {
            _characterInventory.addItem("PotatoSeed");
        }
    }

    public void addTomatoSeedItem()
    {
        if (_characterInventory.activeItem() == null && MoneyManager.instance.decreseMoney(100))
        {
            _characterInventory.addItem("TomatoSeed");
        }
    }
}
