using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class EatingGrassSoundHandler : MonoBehaviour
{
    AudioSource _audio;

    [SerializeField] AnimationCurve _volumeFalloff;

    // Start is called before the first frame update
    void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void StartGrassEatingSound()
    {
        Debug.Log("StartGrassEatingSound");
        if (!_audio.isPlaying || _audio.volume <= 0)
        {
            _audio.Play();
        }

        StopAllCoroutines();
        StartCoroutine(ReduceVolume());
    }

    IEnumerator ReduceVolume()
    {
        var elapsedTime = 0f;
        do 
        {
            _audio.volume = _volumeFalloff.Evaluate(elapsedTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        } while (_audio.volume > 0);
    }
}
