using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    public float sliderValue;
    private Toggle toggle;
    public bool load;

    private void Start()
    {
        load = false;
        //toggle.onValueChanged.AddListener(toggleChanged);
    }
    
    //public bool toggleChanged()
    //{

    //}
    //GameObject.Find("MusicManager").GetComponent<AudioSource>().mute = false;
}
