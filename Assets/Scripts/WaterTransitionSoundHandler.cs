using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class WaterTransitionSoundHandler : MonoBehaviour
{
    [SerializeField] AudioClip _enterWater, _exitWater;

    AudioSource _source;

    void Awake()
    {
        _source = GetComponent<AudioSource>();
    }

    void OnWaterEnter()
    {
        _source.PlayOneShot(_enterWater);
    }

    void OnWaterExit()
    {
        _source.PlayOneShot(_exitWater);
    }
}
