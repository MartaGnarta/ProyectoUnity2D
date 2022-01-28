using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ShootingSystemData")]
public class ShootingSystemData : ScriptableObject
{
    public GameObject projectile;
    public int fireForce;
}
