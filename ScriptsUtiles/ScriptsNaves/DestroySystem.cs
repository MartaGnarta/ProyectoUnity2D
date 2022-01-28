using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DestroySystem : MonoBehaviour
{
    public event Action ExplosionParticles = delegate { };

    void OnEnable()
    {
        GetComponent<HealthSystem>().DestroyP += DestroyPlayer;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().DestroyP -= DestroyPlayer;
    }

    private void DestroyPlayer()
    {
        gameObject.SetActive(false);
    }

    private void FixedUpdate()
    {
        Vector3 pos = transform.position;
        Vector3 normpos = Camera.main.WorldToViewportPoint(pos);

        if (normpos.x < 0 || normpos.y > 1 || normpos.x > 1 || normpos.y < 0)
        {
            gameObject.SetActive(false);
        }
    }
}
