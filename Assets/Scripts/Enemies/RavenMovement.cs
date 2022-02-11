using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RavenMovement : MonoBehaviour
{
    public float velocity;
    public float distanceBetweenplant;

    private RavenSpawn _ravenSpawn;
    private RavenAttack _ravenAttack;
    private GameObject plant;
    private GameObject point;

    private void Start()
    {
        GameObject[] plants;
        plants = GameObject.FindGameObjectsWithTag("plant");
        plant = plants[Random.Range(0, plants.Length)];

        GameObject[] points;
        points = GameObject.FindGameObjectsWithTag("enemySpawn");
        point = points[Random.Range(0, points.Length)];

        _ravenSpawn = GetComponent<RavenSpawn>();
        _ravenAttack = GetComponent<RavenAttack>();

        //for (int i = 0; i < _ravenSpawn.enemySpawnPoints.Length; i ++)
        //{
        //    points[i] = _ravenSpawn.enemySpawnPoints[i];
        //}

        //Transform point = points[Random.Range(0, points.Length)];
    }

    private void Update()
    {
        if (!_ravenAttack.attackedEnded)
        {
            movement(plant.transform);
        }
        else
        {
            movement(point.transform);
        }        
    }

    public void movement(Transform target)
    {      
        if (transform.position.x - target.position.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            if (transform.position.x - target.position.x > 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
        }

        Vector2 dir1 = new Vector2(target.position.x - distanceBetweenplant / 2, target.position.y + distanceBetweenplant);
        Vector2 ravenDir = new Vector2(transform.position.x, transform.position.y);

        transform.position = Vector2.MoveTowards(ravenDir, dir1, velocity * Time.deltaTime);

        if (ravenDir != dir1)
        {
            GetComponent<Animator>().SetBool("attack", false);
        }
    }
}
