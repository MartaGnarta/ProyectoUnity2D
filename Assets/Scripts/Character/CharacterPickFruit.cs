using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CharacterPlant : MonoBehaviour
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
            if (Input.GetButtonDown("Fire1"))
            {
                other.GetComponent<PlantPhases>().ResetPhase();
            }            
        }
    }
}
