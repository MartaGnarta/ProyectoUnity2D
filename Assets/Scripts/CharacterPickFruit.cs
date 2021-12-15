using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPickFruit : MonoBehaviour
{
    public LayerMask mask;

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

    // Start is called before the first frame update
    void Start()
    {
        _plantPhases = FindObjectOfType<PlantPhases>();
    }

    private void pickFruit()
    {
        if ((mask.value & (1 << transform.gameObject.layer)) > 0)
        {
            _plantPhases.ResetPhase();
        }        
    }
}
