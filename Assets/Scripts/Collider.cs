using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    private TomatoAnimation _tomatoAnimation;
    private void Awake()
    {
        _tomatoAnimation = GetComponent<TomatoAnimation>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {        
        if (other.gameObject.name == "Tomato")
        {
            Debug.Log("Puta");
            if (Input.GetKeyDown(KeyCode.X))
                _tomatoAnimation.ResetPhase();
        }
    }
}
