using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoAnimation : MonoBehaviour
{
    private Animator _animator;
    private Controller _controller;

    public int phaseNum;
    public float[] waitTime;

    private void Awake()
    {
        phaseNum = 0;
        _animator = GetComponent<Animator>();
        _controller = GetComponent<Controller>();
    }

    private void Update()
    {
        if (_controller.GetTime() < waitTime[0])
        {
            phaseNum = 1;
            _animator.SetInteger("phase", phaseNum);
        }

        if (_controller.GetTime() < waitTime[1])
        {
            phaseNum = 2;
            _animator.SetInteger("phase", phaseNum);
        }

        if (_controller.GetTime() < waitTime[2])
        {
            phaseNum = 3;
            _animator.SetInteger("phase", phaseNum);
        }
    }
}

