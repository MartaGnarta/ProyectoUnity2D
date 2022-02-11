using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/PlantScriptableObject")]
public class PlantScriptableObject : ScriptableObject
{
    public float growTime;
    public float[] delayTimeToGrow;
    public int PhaseIndex;
    public string plantName;   

    public bool timePaused;    

    public RuntimeAnimatorController plantAnimationController;    

}
