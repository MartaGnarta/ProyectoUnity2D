using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantPhases : MonoBehaviour
{
    public int phaseNum;
    public float[] waitTime;

    private Controller _controller;

    void Start()
    {
        _controller = GetComponent<Controller>();

        phaseNum = 0;
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
        }
    }

    public void ResetPhase()
    {
        Debug.Log("si");
        if (phaseNum == 3)
        {
            phaseNum = 2;
            _controller.ResetTimer();
        }
    }
}
