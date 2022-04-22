using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    Rigidbody _body;

    void Awake()
    {
        _body = GetComponent<Rigidbody>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {        
        var direction = context.ReadValue<Vector2>();
        if (direction.sqrMagnitude > 0)
        {
            // _state._currentMovement = new Vector3(direction.x, 0, direction.y) * _speed;
            // GetComponent<Rigidbody>().AddForce(new Vector3(direction.x, 0, direction.y) * 100);
            _body.velocity = new Vector3(direction.x, 0, direction.y) * 10;
        }
        else
        {
            // _state._currentMovement = Vector3.zero;
            _body.velocity = Vector3.zero;
        }
    }
}
