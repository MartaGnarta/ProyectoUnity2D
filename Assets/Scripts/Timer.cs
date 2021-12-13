using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeValue = 90;
    private DisplayTimer _displayTimer;

    private void Awake()
    {
        _displayTimer = GetComponent<DisplayTimer>();
    }

    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;

        }

        _displayTimer.DisplayTime(timeValue);
    }

    public void resetTimer()
    {
        timeValue = 20;
    }
}
