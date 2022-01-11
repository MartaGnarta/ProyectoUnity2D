using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPickFruit : MonoBehaviour
{
    public LayerMask mask;

    public void OnTriggerEnter2D(Collider2D other)
    {        
        if ((mask.value & (1 << other.transform.gameObject.layer)) > 0)
        {
            Debug.Log(LayerMask.LayerToName(8));

            other.GetComponent<PlantPhases>().ResetPhase();
        }
    }
}
