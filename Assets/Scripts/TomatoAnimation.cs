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

    void OnEnable()
    {
        GetComponent<Collider>().OnFire += ResetPhase; // Suscribirse al evento. Shoot nombre de la funcion sin parentesis
    }

    void OnDisable()
    {
        GetComponent<Collider>().OnFire -= ResetPhase; // Desuscribirse
    }

    private void Update()
    {
        NextPhase();        
        _animator.SetInteger("phase", phaseNum);
    }

    private void ResetPhase()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            phaseNum = 2;
            _controller.ResetTimer();
            Debug.Log("AAAAA");

        }
    }

    public void NextPhase()
    {
        if (_controller.GetTime() < waitTime[0])
        {
            phaseNum = 1;            
        }
        if (_controller.GetTime() < waitTime[1])
        {
            phaseNum = 2;            
        }
        if (_controller.GetTime() < waitTime[2])
        {
            phaseNum = 3;
            ResetPhase();
        }
    }
}
