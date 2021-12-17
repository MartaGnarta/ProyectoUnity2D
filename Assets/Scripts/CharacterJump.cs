using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    private InputSystemKeyboard _input;
    private Rigidbody2D _rb;
    private SpriteRenderer _sp;
    private Animator _anim;
    private Collider _collider;

    private bool t;

    public float jumpspeed;
    public Transform GroundChecker;
    public float radius;
    public LayerMask groundMask;

    void OnEnable()
    {
        GetComponent<InputSystemKeyboard>().Jumping += Jump;
    }

    void OnDisable()
    {
        GetComponent<InputSystemKeyboard>().Jumping -= Jump;
    }

    private void Start()
    {
        _input = GetComponent<InputSystemKeyboard>();
        _rb = GetComponent<Rigidbody2D>();
        _sp = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();
        _collider = GetComponent<Collider>();
    }

    void Update()
    {
        t = Physics2D.OverlapCircle(GroundChecker.position, radius, groundMask);
    }
    private void Jump()
    {
        if (t)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, jumpspeed);
        }
    }
}
