using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowCinematic : MonoBehaviour
{
    private PlantPhases _phases;

    public int index;

    private bool fired;

    private void Start()
    {
        _phases = GetComponent<PlantPhases>();
    }

    void Update()
    {
        if (!fired)
        {
            if (_phases.phaseNum == 3)
            {
                CinematicManager.Instance.OnTriggerCinematic(index);

                fired = true;
            }
        }
    }
}
