using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainFull : MonoBehaviour
{
    public bool full;

    private void Start()
    {
        full = false;
    }

    public void Placed()
    {
        full = true;
    }
}
