using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _prefabToSpawn;

    // Update is called once per frame
    public void Spawn()
    {
        Instantiate(_prefabToSpawn, this.transform.position, this.transform.rotation);
    }
}
