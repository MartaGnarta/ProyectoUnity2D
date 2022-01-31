using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSettings : MonoBehaviour
{
    public Toggle musicToggle;
    public Slider musicSlider;
    public bool load;

    private void Start()
    {
        musicToggle.onValueChanged.AddListener((load) =>
        {
            toggleChanged(load);
        }
        );

        musicSlider.onValueChanged.AddListener(delegate { sliderChanged(); });
    }

    private void toggleChanged(bool load)
    {
        if (load)
        {
            Debug.Log("Musica desactivada: " + load);
            SoundManager.PauseMusic();
        }
        else
        {
            Debug.Log("Musica desactivada: " + load);
            SoundManager.ResumeMusic();
        }
    }

    private void sliderChanged()
    {
        Debug.Log("Musica bajada a: " + musicSlider.value);
        SoundManager.GetMusicObject().GetComponent<AudioSource>().volume = musicSlider.value;
    }
}