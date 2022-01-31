using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcaterPickItemsFromShed : MonoBehaviour
{
    private void Start()
    {
        GameObject gameObject = GameObject.Find("GameManager");
        gameObject.GetComponent<GameManager>();
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("shed"))
        {
            if (!gameObject.GetComponent<GameManager>().isInventoryActive())
            {

            } 
        }
    }
}
