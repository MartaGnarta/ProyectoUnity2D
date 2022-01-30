using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        SoundManager.PlaySound(SoundManager.Sound.Background);
    }

    //static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {

        Cursor.visible = true;

        //if (instance == null)
        //{
        //    GameObject.DontDestroyOnLoad(gameObject);
        //    instance = this;
        //}
        //else
        //{
        //    GameObject.Destroy(gameObject);
        //}
    }
}
