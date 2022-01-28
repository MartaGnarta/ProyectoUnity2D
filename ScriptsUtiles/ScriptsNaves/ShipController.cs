using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    private ShootingSystem launcher;
    public Transform[] shotPoints;
    public ShootingSystemData[] shootingData;

    void Awake()
    {
        if (TryGetComponent(out InputSystemKeyboard sk))
            sk.OnFire += Shoot;
    }

    void Start()
    {
        launcher = GetComponent<ShootingSystem>();
    }

    void Shoot()
    {
        launcher.Shoot();
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    gameObject.AddComponent<ShootSystem>();
        //}
        //if (Input.GetKeyDown(KeyCode.V))
        //{
        //    gameObject.AddComponent<PlasmaSystem>();
        //}

        var input = Input.inputString;

        if (Input.GetKeyDown(KeyCode.B))
        {
            if (GetComponent<ShootSystem>() == null)
            {
                //ShootingSystem sh = Resources.Load<ShootingSystem>("ShotData");
                Destroy(gameObject.GetComponent<MissileSystem>());
                ShootSystem s = gameObject.AddComponent<ShootSystem>();
                s.shootingdata = shootingData[0];
                s.shotPoint = shotPoints[0];
                launcher = s;
            }
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            if (GetComponent<MissileSystem>() == null)
            {
                //ShootingSystem sh = Resources.Load<ShootingSystem>("ShotData");
                Destroy(gameObject.GetComponent<ShootSystem>());
                MissileSystem m = gameObject.AddComponent<MissileSystem>();
                m.shootingdata = shootingData[1];
                m.shotPoint = shotPoints[0];
                launcher = m;
            }
        }
    }
}
