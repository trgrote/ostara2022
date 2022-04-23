using System;
using System.Collections;
using System.Collections.Generic;
using rho;
using UnityEngine;
using UnityEngine.UI;

public class RemainingGrassDisplay : MonoBehaviour
{
    [SerializeField] rho.RuntimeGameObjectSet _grass;
    
    Text _text;

    // Update is called once per frame
    void OnEnable()
    {
        _grass.SetChanged += OnGrassChanged;
    }

    void Awake()
    {
        _text = GetComponent<Text>();
    }

    void Start()
    {
        OnGrassChanged(_grass);
    }

    private void OnGrassChanged(RuntimeSet<GameObject> sender)
    {
        _text.text = $"Eat {sender.Count} More Grass for Pan!";
    }

    void OnDisable()
    {
        _grass.SetChanged -= OnGrassChanged;
    }
}
