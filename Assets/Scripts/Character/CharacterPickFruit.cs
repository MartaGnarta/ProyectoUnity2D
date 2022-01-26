using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPickFruit : MonoBehaviour
{
    private CharacterInventory _characterInventory;
    private int fruitNum;

    private void Start()
    {
        _characterInventory = GetComponent<CharacterInventory>();
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("plants"))
        {
            var _plant = other.GetComponent<PlantPhases>();

            if (Input.GetButtonDown("Fire1")) //&& _plant.phaseNum == 3
            {
                _plant.ResetPhase();
                _characterInventory.prueba();               
            }
        }
    }
}
