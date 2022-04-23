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
        var count = sender.Count;
        _text.text = count > 0 ? $"Eat {count} More Blades of Grass for Pan!" : "PAN IS PLEASED!";
    }

    void OnDisable()
    {
        _grass.SetChanged -= OnGrassChanged;
    }
}
