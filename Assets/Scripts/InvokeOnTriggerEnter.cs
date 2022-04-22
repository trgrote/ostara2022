using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InvokeOnTriggerEnter : MonoBehaviour
{
    [SerializeField] rho.RuntimeGameObjectSet _destroyableObjects;

    [SerializeField] UnityEvent<GameObject> _callbacks;

    void OnTriggerEnter(Collider other)
    {
        if (_destroyableObjects.Contains(other.gameObject))
        {
            _callbacks.Invoke(other.gameObject);
        }
    }
}
