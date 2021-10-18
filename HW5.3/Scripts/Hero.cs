using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class Hero : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Animator _animator;
    private const string _isRun = "isRun";
    private SpriteRenderer _flipHero;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _flipHero = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _flipHero.flipX = false;
            _animator.SetBool(_isRun, true);
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _flipHero.flipX = true;
            _animator.SetBool(_isRun, true);
            transform.Translate(-(_speed * Time.deltaTime), 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            _animator.SetBool(_isRun, false);
            transform.Translate(0, _jumpForce * (_speed * Time.deltaTime), 0);
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            _animator.SetBool(_isRun, false);
        }
    }
}
