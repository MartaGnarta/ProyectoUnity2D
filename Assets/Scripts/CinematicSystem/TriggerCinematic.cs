using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCinematic : MonoBehaviour
{
    public int index;
    public Transform gameManager;

    bool fired;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!fired)
        {
            CinematicManager.Instance.OnTriggerCinematic(index);

            fired = true;
        }

    }
}