using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPickFruit : MonoBehaviour
{
    private Inventory _inventory;

    private void Start()
    {
        _inventory = GetComponent<Inventory>();
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("terrain"))
        {
            var f = other.GetComponent<TerrainFull>();

            if (Input.GetButtonDown("Fire1") && !f.full)
            {
                Instantiate(_inventory.plant, other.transform.position, other.transform.rotation);
                f.Placed();
            }
        }
    }
}
