using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Coin : MonoBehaviour
{
    [SerializeField] private float _speedRotate;

    private void Start()
    {
        _speedRotate *= Time.deltaTime;
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * _speedRotate);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Hero>(out Hero hero))
        {
            Destroy(this.gameObject);
        }
    }
}
