using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CutGrassHandler : MonoBehaviour
{
    [SerializeField] UnityEvent _callbacks;
    
    // Start is called before the first frame update
    void CutGrass()
    {
        _callbacks.Invoke();
        Destroy(this.gameObject);
    }
}
