using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    static GameManager instance;

    private PauseMenu _pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        _pauseMenu = GetComponent<PauseMenu>();

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

    private void Update()
    {
        _pauseMenu.DrawMenu();        
    }

}
