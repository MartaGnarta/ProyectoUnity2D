using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ravenBack")
            Destroy(other.gameObject);
    }
}
