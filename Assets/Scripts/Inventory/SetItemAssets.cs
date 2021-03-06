using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetItemAssets : MonoBehaviour
{
    public static SetItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public PlantScriptableObject[] plantScriptableObjects;
    public Sprite[] item;
    public GameObject[] prefabs;
    public Sprite deathPlant;

    public SoundAudioClip[] soundAudioClips;

    [System.Serializable]
    public class SoundAudioClip
    {
        public SoundManager.Sound sound;
        public AudioClip audioClip;
    }
}

