using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlantSystem : MonoBehaviour
{
    public PlantScriptableObject plantData;
    public ParticleSystem growParticles;
    public ParticleSystem bugParticles;
    public bool infected;
    public bool isplantDeath;

    public abstract void growPlant();
    public abstract void resetPhase();
    public abstract void plantTimer();
    public abstract void plantAnimation();
    public abstract void plantDeath();
    public abstract void plantParticles();
    public abstract void plantInfection();
    public abstract void plantDeathByInfection();
}
