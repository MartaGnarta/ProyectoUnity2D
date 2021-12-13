using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Controller _controller;

    private void Awake()
    {
        _controller = GetComponent<Controller>();
    }
}
