using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantPhases : MonoBehaviour
{
    public int phaseNum;
    public float[] waitTime;

    private Controller _controller;
    private ParticlesManager _particleManager;

    void Start()
    {
        _controller = GetComponent<Controller>();
        _particleManager = GetComponent<ParticlesManager>();

        phaseNum = 0;
    }

    public void NextPhase()
    {
        if (_controller.GetTime() < waitTime[0] && phaseNum == 0)
        {
            phaseNum = 1;
        }
        if (_controller.GetTime() < waitTime[1] && phaseNum == 1)
        {
            phaseNum = 2;
        }
        if (_controller.GetTime() < waitTime[2] && phaseNum == 2)
        {
            _controller.PauseTimer();
            phaseNum = 3;
            _particleManager.DrawParticles();
            SoundManager.PlaySound(SoundManager.Sound.PlantGrow);
        }
    }

    public void ResetPhase()
    {
        if (phaseNum == 3)
        {
            phaseNum = 2;
            _controller.ResetTimer();
            _controller.PlayTimer();
        }
    }
}
