using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collider : MonoBehaviour
{
    public event Action OnFire = delegate { };

    //private TomatoAnimation _tomatoAnimation;
    //private void Awake()
    //{
    //    _tomatoAnimation = GetComponent<TomatoAnimation>();
    //}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Tomato")
        {
            OnFire();
            Debug.Log("Puta");
            //if (Input.GetKeyDown(KeyCode.))
            //{
            //    Debug.Log("Puta");
                
            //}                
        }
    }
}
