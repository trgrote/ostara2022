using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterIdleSoundPlayer : MonoBehaviour
{
    [SerializeField] PlayerState _state;

    AudioSource _source;

    // Start is called before the first frame update
    void Awake()
    {
        _source = GetComponent<AudioSource>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (_state._isSlowed && !_source.isPlaying)
        {
            _source.Play();
        }
        else if (!_state._isSlowed && _source.isPlaying)
        {
            _source.Stop();
        }
    }
}
