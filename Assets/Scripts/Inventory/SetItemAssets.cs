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

    public GameObject[] prefabs;
    public Sprite[] item;
}

