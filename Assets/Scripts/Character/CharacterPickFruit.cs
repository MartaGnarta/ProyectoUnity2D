using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPickFruit : MonoBehaviour
{
    private CharacterInventory _characterInventory;

    private void Start()
    {
        _characterInventory = GetComponent<CharacterInventory>();
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("plants"))
        {
            var _plant = other.GetComponent<GrowingSystem>();

            if (Input.GetButtonDown("Fire1") && _plant.plantData.PhaseIndex == 3 && _characterInventory.activeItem() == null)
            {
                Debug.Log(_plant.plantData.plantName);
                _plant.resetPhase();
                _characterInventory.addItem(_plant.plantData.plantName);               
            }
        }
    }
}
