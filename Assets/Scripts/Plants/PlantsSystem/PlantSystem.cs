using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlantSystem : MonoBehaviour
{
    public PlantScriptableObject plantData;
    public ParticleSystem growParticles;

    public abstract void growPlant();
    public abstract void resetPhase();
    public abstract void plantTimer();
    public abstract void plantAnimation();
    public abstract void plantParticles();
}
