using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManager {
    public enum Sound
    {
        PlayerPlant,
        PlantGrow,
        Background,
        MeowSound,
    }

    public static GameObject GetSoundObject()
    {
        return GameObject.Find("SoundManager");
    }

    public static GameObject GetMusicObject()
    {
        return GameObject.Find("MusicManager");
    }

    public static void PlaySound(Sound sound)
    {
        GetSoundObject().GetComponent<AudioSource>().PlayOneShot(GetAudioClip(sound));
    }

    public static void PauseSound()
    {
        GetSoundObject().GetComponent<AudioSource>().mute = true;
    }

    public static void ResumeSound()
    {
        GetSoundObject().GetComponent<AudioSource>().mute = false;
    }

    public static void PauseMusic()
    {
        GetMusicObject().GetComponent<AudioSource>().mute = true;
    }

    public static void ResumeMusic()
    {
        GetMusicObject().GetComponent<AudioSource>().mute = false;
    }

    public static bool isSoundMuted()
    {
        return GetSoundObject().GetComponent<AudioSource>().mute;
    }

    public static bool isMusicMuted()
    {
        return GetMusicObject().GetComponent<AudioSource>().mute;
    }

    public static void soundValue()
    {

    }

    private static AudioClip GetAudioClip(Sound sound)
    {
        foreach (SetItemAssets.SoundAudioClip soundAudioClip in SetItemAssets.Instance.soundAudioClips)
        {
            if (soundAudioClip.sound == sound)
            {
                return soundAudioClip.audioClip;
            }
        }
        return null;
    }
}
