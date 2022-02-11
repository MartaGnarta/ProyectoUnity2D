using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGiveFruit : MonoBehaviour
{
    private CharacterInventory _characterInventory;

    [SerializeField]
    private UpdateScore score;

    private void Start()
    {
        _characterInventory = GetComponent<CharacterInventory>();
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("basket"))
        {            
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (_characterInventory.activeItem() != null && _characterInventory.activeItem().itemState == SetItem.ItemState.fruit)
                {
                    Debug.Log(MoneyManager.instance.activeMoney);
                    MoneyManager.instance.increseMoney(_characterInventory.activeItem().price);                    
                    _characterInventory.useItem();                    
                }
            }
        }
    }
}
