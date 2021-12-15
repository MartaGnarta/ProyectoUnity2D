using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private InputSystemKeyboard _input;
    private Rigidbody2D _rb;
    private SpriteRenderer _sp;
    private Animator _anim;
    private Collider _collider;

    [SerializeField]
    private float _velocity;

    void Start()
    {
        _input = GetComponent<InputSystemKeyboard>();
        _rb = GetComponent<Rigidbody2D>();
        _sp = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();
        _collider = GetComponent<Collider>();       
    }

    void Update()
    {
        _rb.velocity = new Vector2(_input.hor * _velocity, _rb.velocity.y);

        if (_input.hor > 0)
        {
            _sp.flipX = false;
        }
        else
        {
            if (_input.hor < 0)
            {
                _sp.flipX = true;
            }
        }

        if (_input.hor != 0)
        {
            _anim.SetBool("run", true);
        }

        if (_input.hor == 0)
        {
            _anim.SetBool("run", false);
        }        
    }
}
