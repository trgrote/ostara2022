using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeathSpawn : MonoBehaviour
{
    [SerializeField] GameObject _prefabToSpawn;

    // Update is called once per frame
    void OnDestroy()
    {
        Instantiate(_prefabToSpawn, this.transform.position, this.transform.rotation);
    }
}
