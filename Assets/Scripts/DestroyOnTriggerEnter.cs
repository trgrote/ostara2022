using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Destory Trigger Object when this object enters it's trigger zone
public class DestroyOnTriggerEnter : MonoBehaviour
{
    [SerializeField] rho.RuntimeGameObjectSet _destroyableObjects;

    void OnTriggerEnter(Collider other)
    {
        if (_destroyableObjects.Contains(other.gameObject))
        {
            Destroy(other.gameObject);
        }
    }
}
