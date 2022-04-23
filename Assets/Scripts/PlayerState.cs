using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player State")]
public class PlayerState : ScriptableObject
{
    public Vector3 _currentMovement = Vector3.zero;
    public bool _isSlowed = false;
}
