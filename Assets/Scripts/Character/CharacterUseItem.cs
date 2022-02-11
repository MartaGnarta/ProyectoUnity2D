using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterUseItem : MonoBehaviour
{
    private CharacterInventory _characterInventory;

    public bool touching = false;
    private Collider2D plant;

    private void Start()
    {
        _characterInventory = GetComponent<CharacterInventory>();
    }

    private void Update()
    {
        useItem();

    }

    private void useItem()
    {        
        if (_characterInventory.activeItem() == null)
        {
            return;
        }        

        if (_characterInventory.activeItem().itemType.ToString().ToLower() == "insecticide" && touching)
        {
            var growingSystem = plant.GetComponent<GrowingSystem>();

            if (Input.GetButtonDown("Fire1") && growingSystem.infected)
            {
                growingSystem.infected = false;
                _characterInventory.useItem();
            }
        }
        else if (_characterInventory.activeItem().itemType.ToString().ToLower() == "scarecrow")
        {           
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("entra?");
                Instantiate(SetItemAssets.Instance.prefabs[0], new Vector2(transform.position.x, transform.position.y - 0.1f), Quaternion.identity);
                _characterInventory.useItem();
            }
        }
        else if (_characterInventory.activeItem().itemType.ToString().ToLower() == "wateringcan" && touching)
        {
            if (Input.GetButtonDown("Fire1"))
            {               
                _characterInventory.useItem();
            }
        }
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("plants"))
        {
            plant = other;
            touching = true;      
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("plants"))
        {
            touching = false;
        }
    }

}
