using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite tomato;
    public Sprite potato;
    public Sprite beet;
    public Sprite eggplant;
    public Sprite tomatoSeed;
    public Sprite potatoSeed;
    public Sprite beetSeed;
    public Sprite eggplantSeed;
}
