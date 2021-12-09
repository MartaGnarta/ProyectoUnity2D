using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Timer _timer;

    private void Awake()
    {
        _timer = GetComponent<Timer>();
    }
    public float GetTime()
    {
        return _timer.timeValue;
    }
}
