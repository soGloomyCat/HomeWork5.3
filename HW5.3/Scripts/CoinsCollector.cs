using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCollector : MonoBehaviour
{
    private int _coinsQuality;

    private void Start()
    {
        _coinsQuality = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            _coinsQuality++;
            Debug.Log($"Ñîáðàíî ìîíåò - {_coinsQuality}");
        }
    }
}
