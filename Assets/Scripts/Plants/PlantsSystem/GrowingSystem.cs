using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingSystem : PlantSystem
{
    public float time;

    private void Start()
    {
        gameObject.GetComponent<Animator>().runtimeAnimatorController = plantData.plantAnimationController as RuntimeAnimatorController;

        plantData.timePaused = false;
        plantData.PhaseIndex = 0;
        time = plantData.growTime;

        growParticles = Instantiate(growParticles, transform.position, Quaternion.identity);
        bugParticles = Instantiate(bugParticles, transform.position, Quaternion.identity);

        growParticles.Stop();
        bugParticles.Stop();

        Invoke("plantInfection", 70.0f);
    }

    private void Update()
    {
        if (!plantData.timePaused)
        {
            plantTimer();
        }

        growPlant();
        plantAnimation();

        if (!infected)
        {
            bugParticles.Stop();
        }
    }

    public override void growPlant()
    {
        if (!isplantDeath)
        {
            if (time < plantData.delayTimeToGrow[0] && plantData.PhaseIndex == 0)
            {
                plantData.PhaseIndex = 1;
            }
            else if (time < plantData.delayTimeToGrow[1] && plantData.PhaseIndex == 1)
            {
                plantData.PhaseIndex = 2;
            }
            else if (time < plantData.delayTimeToGrow[2] && plantData.PhaseIndex == 2)
            {
                plantData.timePaused = true;
                plantData.PhaseIndex = 3;
                plantParticles();
                SoundManager.PlaySound(SoundManager.Sound.PlantGrow);
            }
        }
    }
    public override void resetPhase()
    {
        if (plantData.PhaseIndex == 3 && !isplantDeath)
        {
            time = plantData.growTime;
            plantData.PhaseIndex = 2;            
            plantData.timePaused = false;
        }
    }
    public override void plantTimer()
    {
        if (!plantData.timePaused)
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
    }
    public override void plantAnimation()
    {
        gameObject.GetComponent<Animator>().SetInteger("phase", plantData.PhaseIndex);
    }

    public override void plantDeath()
    {
        gameObject.GetComponent<Animator>().SetBool("death", true);
        gameObject.GetComponent<SpriteRenderer>().sprite = SetItemAssets.Instance.deathPlant;
        isplantDeath = true;
        gameObject.tag = "plantDeath";
    }

    public override void plantParticles()
    {
        if (!isplantDeath)
        {
            growParticles.Play();
        }        
    }

    public override void plantInfection()
    {
        if (!isplantDeath)
        {
            infected = true;
            bugParticles.Play();
            Invoke("plantDeathByInfection", 40.0f);
        }
    }

    public override void plantDeathByInfection()
    {
        if (infected && !isplantDeath)
        {
            bugParticles.Stop();
            plantDeath();            
        }
    }
}
