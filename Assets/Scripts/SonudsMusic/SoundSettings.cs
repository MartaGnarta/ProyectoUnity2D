using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    public Toggle toggle;
    public Slider slider;
    public bool load;

    private void Start()
    {
        //slider.value = sliderValue;

        toggle.onValueChanged.AddListener((load) =>
        {
            toggleChanged(load);
        }
        );

        slider.onValueChanged.AddListener(delegate { sliderChanged(); });
    }

    private void toggleChanged(bool load)
    {
        if (load)
        {
            Debug.Log("Sonido desactivado: " + load);
            SoundManager.PauseSound();
        }
        else
        {
            Debug.Log("Sonido desactivado: " + load);
            SoundManager.ResumeSound();
        }      
    }

    private void sliderChanged()
    {
        Debug.Log("Sonido bajado a: " + slider.value);
        SoundManager.GetSoundObject().GetComponent<AudioSource>().volume = slider.value;
    }
}
    
