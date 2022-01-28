using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Engine : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float turnSpeed;

    private InputSystemKeyboard inputSystem;

    void Awake() // se ejecuta cuando se activa el objeto
    {
        inputSystem = GetComponent<InputSystemKeyboard>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += inputSystem.ver * transform.up * speed * Time.deltaTime;
        transform.Rotate(new Vector3(0, 0, -1) * inputSystem.hor * turnSpeed * Time.deltaTime);
    }
}
