using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSystem : ShootingSystem
{
    public override void Shoot()
    {
        GameObject rocket = PoolingManager.Instance.GetPooledObject("Rocket");

        if (rocket != null)
        {
            rocket.transform.position = shotPoint.position;
            rocket.transform.rotation = shotPoint.rotation;
            rocket.SetActive(true);
            rocket.GetComponent<Rigidbody2D>().AddForce(transform.up * shootingdata.fireForce);                      
        }        
    }
}
//var shot = Instantiate(shootingdata.projectile, shotPoint.position, shotPoint.rotation);
//shot.GetComponent<Missile>().SetTarget(GameObject.Find("Meteor").transform);
//shot.GetComponent<Rigidbody2D>().AddForce(transform.up * shootingdata.fireForce);
//rocket.GetComponent<Missile>().SetTarget(GameObject.Find("Meteorito").transform);