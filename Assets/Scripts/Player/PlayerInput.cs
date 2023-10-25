using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerMover _playerMover;

    private void Start()
    {
        _playerMover = GetComponent<PlayerMover>();
    }
    private void Update()
    {
        MoveControl();
    }

    private void MoveControl()
    {
        //const string  Horizontal = "Horizontal";

        if (_playerMover.MainDirection != null)
        {
            _playerMover.Move();
        }
    }
}
