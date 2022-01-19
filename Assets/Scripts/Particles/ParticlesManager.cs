using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesManager : MonoBehaviour
{
    public ParticleSystem[] particles;
    public void DrawParticles()
    {
        Instantiate(particles[0], transform.position, Quaternion.identity);
    }
}
