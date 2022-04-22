using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    CharacterController _controller;
    [SerializeField] float _speed = 1f;
    [SerializeField] PlayerState _state;

    void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _state._currentMovement = Vector3.zero;
    }

    public void OnMove(InputAction.CallbackContext context)
    {        
        var direction = context.ReadValue<Vector2>();
        if (direction.sqrMagnitude > 0)
        {
            _state._currentMovement = new Vector3(direction.x, 0, direction.y) * _speed;
        }
        else
        {
            _state._currentMovement = Vector3.zero;
        }
    }

    void Update()
    {
        _controller.SimpleMove(_state._currentMovement);
    }
}
