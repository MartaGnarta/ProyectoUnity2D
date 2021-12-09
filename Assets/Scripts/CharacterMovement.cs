using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private InputSystemKeyboard _input;
    private Rigidbody2D _rb;
    private SpriteRenderer _sp;
    private Animator _anim;

    public float jumpspeed;
    //public Transform GroundChecker;
    //public float radius;
    //public LayerMask groundMask;

    [SerializeField]
    private float _velocity;

    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<InputSystemKeyboard>();
        _rb = GetComponent<Rigidbody2D>();
        _sp = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
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

        //bool t = Physics2D.OverlapCircle(GroundChecker.position, radius, groundMask);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //if (t)
            //{
                _rb.velocity = new Vector2(_rb.velocity.x, jumpspeed);
            //}
        }
    }
}
