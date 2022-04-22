using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementRotater : MonoBehaviour
{
    [SerializeField] PlayerState _state;

    // Update is called once per frame
    void Update()
    {
        if (_state._currentMovement.sqrMagnitude > 0)
        {
            // Rotate the mesh position to match the direction the dog is looking
            transform.rotation = Quaternion.LookRotation(_state._currentMovement);
        }
    }
}
