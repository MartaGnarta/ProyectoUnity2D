using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSystem : MonoBehaviour
{
    public GameObject[] meteors;
    //public GameObject meteor2;

    public Transform[] positions;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateMeteor());
    }

    IEnumerator GenerateMeteor()
    {
        int a = Random.Range(0, 4);
        int b = Random.Range(0, 2);

        Instantiate(meteors[b], positions[a].position, Quaternion.identity);
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(GenerateMeteor());
    }
}
