using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootingSystem : MonoBehaviour
{
    //[SerializeField]
    //protected GameObject projectile;

    //[SerializeField]
    //protected int fireForce;

    public ShootingSystemData shootingdata;

    public Transform shotPoint;
        
    public abstract void Shoot();
}
