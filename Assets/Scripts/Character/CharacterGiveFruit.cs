using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGiveFruit : MonoBehaviour
{
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("basket"))
        {
            Debug.Log("Entrega Fruta");
        }
    }
}
