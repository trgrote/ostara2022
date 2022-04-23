using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWaterHandler : MonoBehaviour
{
    [SerializeField] PlayerState _state;

    void OnEnable()
    {
        _state._isSlowed = false;
    }

    // Start is called before the first frame update
    void OnWaterEnter()
    {
        _state._isSlowed = true;        
    }

    // Update is called once per frame
    void OnWaterExit()
    {
        _state._isSlowed = false;        
    }
}
