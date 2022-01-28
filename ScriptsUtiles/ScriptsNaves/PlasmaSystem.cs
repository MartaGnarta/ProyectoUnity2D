using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaSystem : ShootingSystem
{
    void OnEnable()
    {
        GetComponent<InputSystemKeyboard>().OnFire += Shoot; // Suscribirse al evento. Shoot nombre de la funcion sin parentesis
    }

    void OnDisable()
    {
        GetComponent<InputSystemKeyboard>().OnFire -= Shoot; // Desuscribirse
    }
    public override void Shoot()
    {
        var shot = Instantiate(shootingdata.projectile, shotPoint.position, shotPoint.rotation);
        shot.GetComponent<Rigidbody2D>().AddForce(shotPoint.transform.up * shootingdata.fireForce);
    }
}
