using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    private Transform target;

    void Start()
    {
        target = GameObject.Find("Meteorito").transform;
        var angle = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}

//private void Start()
//{
//    target = GameObject.Find("Meteorito").transform;
//    float angle = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) * Mathf.Rad2Deg;
//    transform.rotation = Quaternion.Euler(0, 0, angle);
//}
//public void SetTarget(Transform target)
//{
//    //target = GameObject.Find("Meteor").transform;
//    float angle = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) * Mathf.Rad2Deg;
//    transform.rotation = Quaternion.Euler(0, 0, angle);

//}
/* var shot = Instantiate(projectile, shotPoint.position, shotPoint.rotation);
        shot.GetComponent<Rigidbody2D>().AddForce(shotPoint.transform.up * fireForce);
    } */