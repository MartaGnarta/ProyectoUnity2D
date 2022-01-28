using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public event Action DestroyP = delegate { };
    //public event Action<int> Update = delegate { };

    public void Damaged(int damage)
    {
        health = health - damage;
        //Update(health);

        if (health <= 0)
        {
            DestroyP();
        }
    }
}
