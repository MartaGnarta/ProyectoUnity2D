using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlant : MonoBehaviour
{
    public LayerMask mask;

    private bool triggered;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if ((mask.value & (1 << other.transform.gameObject.layer)) > 0)
        {
            triggered = true;
            Debug.Log(LayerMask.LayerToName(8));
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        triggered = false;
    }
}
