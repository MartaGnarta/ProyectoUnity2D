using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collider : MonoBehaviour
{
    public LayerMask mask;

    public event Action Picking = delegate { };

    public void OnTriggerEnter2D(Collider2D other)
    {
        if ((mask.value & (1 << other.transform.gameObject.layer)) > 0)
        {
            Picking();
        }
    }
}
