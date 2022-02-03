using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingSystem : PlantSystem
{
    private float time;

    private void Start()
    {
        gameObject.GetComponent<Animator>().runtimeAnimatorController = plantData.plantAnimationController as RuntimeAnimatorController;

        plantData.timePaused = false;
        plantData.PhaseIndex = 0;
        time = plantData.growTime;
    }

    private void Update()
    {
        if (!plantData.timePaused)
        {
            plantTimer();
        }

        growPlant();
        plantAnimation();
    }

    public override void growPlant()
    {
        if (time < plantData.delayTimeToGrow[0] && plantData.PhaseIndex == 0)
        {
            plantData.PhaseIndex = 1;
        }
        if (time < plantData.delayTimeToGrow[1] && plantData.PhaseIndex == 1)
        {
            plantData.PhaseIndex = 2;
        }
        if (time < plantData.delayTimeToGrow[2] && plantData.PhaseIndex == 2)
        {
            plantData.timePaused = true;            
            plantData.PhaseIndex = 3;
            plantParticles();
            SoundManager.PlaySound(SoundManager.Sound.PlantGrow);
        }
    }
    public override void resetPhase()
    {
        if (plantData.PhaseIndex == 3)
        {
            time = plantData.growTime;
            plantData.PhaseIndex = 2;            
            plantData.timePaused = false;
        }
    }
    public override void plantTimer()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            time = 0;
        }
    }
    public override void plantAnimation()
    {
        gameObject.GetComponent<Animator>().SetInteger("phase", plantData.PhaseIndex);
    }
    public override void plantParticles()
    {
        Instantiate(growParticles, transform.position, Quaternion.identity);
    }
}
