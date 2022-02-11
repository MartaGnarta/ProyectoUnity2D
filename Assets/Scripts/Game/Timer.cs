using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeValue = 90;
    private DisplayTimer _displayTimer;

    private bool paused;

    private void Awake()
    {
        _displayTimer = GetComponent<DisplayTimer>();
        paused = false;
    }

    void Update()
    {
        if (!paused)
        {
            playTimer();

            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue = 0;

            }
        }
        else
        {
            stopTimer();
        }

        //_displayTimer.DisplayTime(timeValue);
    }

    public void resetTimer()
    {
        timeValue = 20;
    }

    public void stopTimer()
    {
        paused = true;
    }

    public void playTimer()
    {
        paused = false; 
    }
}
