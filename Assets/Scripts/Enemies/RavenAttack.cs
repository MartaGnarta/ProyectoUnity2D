using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RavenAttack : MonoBehaviour
{
    public bool Triggered;
    public bool attacked = false;
    public bool attackedEnded = false;
    private Timer _timer;

    public float timeToAttack;
    private Collider2D plantCollider;

    public event Action attack = delegate { };

    private void Start()
    {
        _timer = GetComponent<Timer>();
    }

    private void Update()
    {
        if (Triggered && !attacked)
        {
            if (_timer.timeValue <= timeToAttack)
            {
                attackAnimation();
                attacked = true;
                plantCollider.GetComponent<GrowingSystem>().plantDeath();
                gameObject.tag = "ravenBack";
            }
        }        
    }

    public void attackAnimation()
    {
        GetComponent<Animator>().SetBool("attack", true);
        Invoke("endAttack", 1.0f);
    }

    public void endAttack()
    {
        attackedEnded = true;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("plants"))
        {
            Triggered = true;                       
            _timer.playTimer();            
            plantCollider = other;
        }

        if (other.gameObject.layer == LayerMask.NameToLayer("player") || other.gameObject.layer == LayerMask.NameToLayer("scarecrow"))
        {
            attackedEnded = true;
            Triggered = false;
            attacked = true;
            gameObject.tag = "ravenBack";
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("plants"))
        {            
            Triggered = false;
            _timer.stopTimer();
        }     
    }
}
