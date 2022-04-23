using System.Collections;
using System.Collections.Generic;
using rho;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] RuntimeGameObjectSet _grass;

    float _time = 0f;

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

    IEnumerator Count()
    {
        while (true)
        {
            _text.text = $"Time: {Mathf.FloorToInt(_time)} seconds";
            _time += Time.deltaTime;
            yield return null;                          
        }        
    }

    private void OnGrassChanged(RuntimeSet<GameObject> sender)
    {
        // If we haven't started counting yet and there is now grass, then start counting
        if (_time == 0f && sender.Count > 0)       
        {
            StartCoroutine(Count());
        }
        else if (_time > 0 && sender.Count == 0)
        {
            // Stop counting if the player ate all the grass
            StopAllCoroutines();
        }
    }

    void OnDisable()
    {
        _grass.SetChanged -= OnGrassChanged;
    }
}
