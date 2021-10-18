using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawn : MonoBehaviour
{
    [SerializeField] private Transform _pathCoins;
    [SerializeField] private Coin _coin;

    private Transform[] _spawnPositions;
    private int _currrentCoinsQuantity;

    private void Start()
    {
        _spawnPositions = new Transform[_pathCoins.childCount];
        _currrentCoinsQuantity = 0;

        for (int i = 0; i < _spawnPositions.Length; i++)
        {
            _spawnPositions[i] = _pathCoins.GetChild(i);
        }

        while (_currrentCoinsQuantity < _spawnPositions.Length)
        {
            Instantiate(_coin, _spawnPositions[_currrentCoinsQuantity].position, Quaternion.identity);
            _currrentCoinsQuantity++;
        }
    }
}
