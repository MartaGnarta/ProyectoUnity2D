using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RavenSpawn : MonoBehaviour
{
    public Transform[] enemySpawnPoints;
    public GameObject raven;

    private void Start()
    {
        StartCoroutine(spawnEnemy());
    }

    IEnumerator spawnEnemy()
    {
        GameObject[] plants = GameObject.FindGameObjectsWithTag("plant");

        SoundManager.PlaySound(SoundManager.Sound.RavenSound);

        if (plants.Length != 0)
        {
            Instantiate(raven, enemySpawnPoints[Random.Range(0, enemySpawnPoints.Length)].position, Quaternion.identity);          
        }

        yield return new WaitForSeconds(50.0f);
        StartCoroutine(spawnEnemy());
    }
}
