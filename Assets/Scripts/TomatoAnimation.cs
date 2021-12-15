using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoAnimation : MonoBehaviour
{
    private Animator _animator;    
    private PlantPhases _plantPhases;    

    private void Awake()
    {
        _animator = GetComponent<Animator>();        
        _plantPhases = GetComponent<PlantPhases>();
    }

    private void Update()
    {
        _plantPhases.NextPhase();
        _animator.SetInteger("phase", _plantPhases.phaseNum);
    }
}
