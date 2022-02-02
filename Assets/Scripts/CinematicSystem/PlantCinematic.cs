using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantCinematic : MonoBehaviour
{
    private TerrainFull _terrain;

    public int index;

    private bool fired;

    private void Start()
    {
        _terrain = GetComponent<TerrainFull>();
    }

    void Update()
    {
        if (!fired)
        {
            if (_terrain.full)
            {
                CinematicManager.Instance.OnTriggerCinematic(index);

                fired = true;
            }            
        }
    }
}
