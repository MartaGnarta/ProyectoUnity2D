using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform[] points;
    public GameObject plant;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        DrawPlant();
    }

    private void DrawPlant()
    {
        for (int i = 0; i < 6; i++ )
        {
            Instantiate(plant, points[i].position, points[i].rotation);
        }        
    }
}
