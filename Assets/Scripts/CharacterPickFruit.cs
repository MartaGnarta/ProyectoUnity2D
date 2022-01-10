using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPickFruit : MonoBehaviour
{
    public LayerMask mask;

    private bool triggered;

    [SerializeField]
    private PlantPhases _plantPhases;

    void OnEnable()
    {
        GetComponent<InputSystemKeyboard>().OnFire += pickFruit;
    }

    void OnDisable()
    {
        GetComponent<InputSystemKeyboard>().OnFire -= pickFruit;
    }

    void Start()
    {
        _plantPhases = FindObjectOfType<PlantPhases>();
        triggered = false;
    }

    private void pickFruit()
    {        
        if (triggered)
        {
            _plantPhases.ResetPhase();
        }      
    }
    private void pickedFruit()
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
