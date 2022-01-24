using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlant : MonoBehaviour
{
    public GameObject fruit;
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("terrain"))
        {
            var f = other.GetComponent<TerrainFull>();

            if (Input.GetButtonDown("Fire1") && !f.full)
            {
                Instantiate(fruit, other.transform.position, other.transform.rotation);
                f.Placed();
            }
        }
    }
}
