using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlant : MonoBehaviour
{
    public LayerMask mask;

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("plants"))
        {
            Debug.Log("Hay planta");
            if (Input.GetButtonDown("Fire1"))
            {
                other.GetComponent<PlantPhases>().ResetPhase();
            }            
        }
    }
}
