using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterOpenShed : MonoBehaviour
{
    public GameObject menuShed;
    public bool isActive;

    private void Start()
    {
        isActive = false;
        
    }

    private void Update()
    {
        if (isActive)
        {
            openShed();
        }
        else
        {
            closeShed();
        }
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("shed"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                menuShed.SetActive(true);
                changeBoolean();
            }
        }
    }

    public void openShed()
    {
        menuShed.SetActive(true);
    }

    public void closeShed()
    {
        isActive = false;
        menuShed.SetActive(false);
    }

    public void changeBoolean()
    {
        isActive ^= true;
    }
}
