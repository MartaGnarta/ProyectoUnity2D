using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShedManager : MonoBehaviour
{
    private SetInventory inventory;

    [SerializeField]
    private CharacterInventory _characterInventory;

    public void addBeetSeedItem()
    {
        if (_characterInventory.activeItem() == null && MoneyManager.instance.decreseMoney(_characterInventory.getList(4)))
        {
            _characterInventory.addItem("BeetSeed");
        }
    }

    public void addEggplantSeedItem()
    {
        if (_characterInventory.activeItem() == null && MoneyManager.instance.decreseMoney(_characterInventory.getList(5)))
        {
            _characterInventory.addItem("EggplantSeed");
        }
    }

    public void addPotatoSeedItem()
    {
        if (_characterInventory.activeItem() == null && MoneyManager.instance.decreseMoney(_characterInventory.getList(6)))
        {
            _characterInventory.addItem("PotatoSeed");
        }
    }

    public void addTomatoSeedItem()
    {
        if (_characterInventory.activeItem() == null && MoneyManager.instance.decreseMoney(_characterInventory.getList(7)))
        {
            _characterInventory.addItem("TomatoSeed");
        }
    }

    public void addWateringCan()
    {
        if (_characterInventory.activeItem() == null && MoneyManager.instance.decreseMoney(_characterInventory.getList(9)))
        {
            _characterInventory.addItem("WateringCan");
        }
    }

    public void addScarecrow()
    {
        if (_characterInventory.activeItem() == null && MoneyManager.instance.decreseMoney(_characterInventory.getList(8)))
        {            
            _characterInventory.addItem("Scarecrow");
        }
    }

    public void addInsecticide()
    {
        
        if (_characterInventory.activeItem() == null && MoneyManager.instance.decreseMoney(_characterInventory.getList(10)))
        {
            _characterInventory.addItem("Insecticide");
        }
    }

    public void returnItem()
    {
        if (_characterInventory.activeItem() != null)
        {
            _characterInventory.useItem();
        }
    }
}
