using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour
{
    [SerializeField] float _delay;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(_delay);
        Destroy(this.gameObject);
    }
}
