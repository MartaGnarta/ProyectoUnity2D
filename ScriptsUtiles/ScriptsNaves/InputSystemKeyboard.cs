using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputSystemKeyboard : MonoBehaviour
{
    public float hor { get; private set; }
    public float ver { get; private set; }

    public event Action OnFire = delegate { }; // Nombre que queramos 
    //public event Action OnFire = delegate { };

    // Set asignar
    // Get leer
    // Delegate decir que es evento

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Fire1"))
            OnFire();
    }
}
