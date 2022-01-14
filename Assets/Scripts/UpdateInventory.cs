using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateInventory : MonoBehaviour
{

    public GameObject[] items;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(items[0], transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
