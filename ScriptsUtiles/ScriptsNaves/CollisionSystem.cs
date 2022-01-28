using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollisionSystem : MonoBehaviour
{

    [SerializeField]
    private int damage;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out HealthSystem vida))
        {
            vida.Damaged(damage);
        }
    }
}


//OnTrigger2D(Collider2D other)
//s = load scriptableojbect
//other.gameObject.AddComponent(ShootSystem)
//other.gameObject.GetComponent<ShipController>():
