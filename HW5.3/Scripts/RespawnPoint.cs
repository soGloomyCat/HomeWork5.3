using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    [SerializeField] private GameObject _respawnPoint;

    public void Start()
    {
        Instantiate(_hero, _respawnPoint.transform.position, Quaternion.identity);
    }
}
