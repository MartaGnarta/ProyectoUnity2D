using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesSystem : MonoBehaviour
{
    public ParticleSystem particles1;
    public GameObject particles2;

    private GameObject p;

    private InputSystemKeyboard inputSystem;

    void OnEnable()
    {
        GetComponent<HealthSystem>().DestroyP += Generate;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().DestroyP -= Generate;
    }

    void Awake()
    {
        inputSystem = GetComponent<InputSystemKeyboard>();
    }

    // Update is called once per frame
    void Update()
    {
        var emission1 = particles1.emission;

        if (inputSystem.ver != 0 || inputSystem.hor != 0)
        {
            emission1.enabled = true;
        }
        else
        {
            emission1.enabled = false;
        }
    }

    void Generate()
    {
        p = Instantiate(particles2, transform.position, Quaternion.identity);
    }
}