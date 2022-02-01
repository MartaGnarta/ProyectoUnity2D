using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    public Transform gameManager;
    public float speed = 1.0f;

    GameManager gameManagerC;
    Camera cameraC;

    bool cinematicMode;
    Vector3 savedGameplayPosition;
    float savedGameplaySize;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerC = gameManager.GetComponent<GameManager>();
        cameraC = GetComponent<Camera>();
        cinematicMode = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cinematicMode)
        {
            // Nada
        }
        else
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    public void EnterCinematicMode()
    {
        if (!cinematicMode)
        {
            savedGameplayPosition = transform.position;
            savedGameplaySize = cameraC.orthographicSize;

            cinematicMode = true;
        }
    }

    public void ExitCinematicMode()
    {
        if (cinematicMode)
        {
            transform.position = savedGameplayPosition;
            cameraC.orthographicSize = savedGameplaySize;

            cinematicMode = false;
        }
    }

    public void SetSize(float size)
    {
        cameraC.orthographicSize = size;
    }
}
