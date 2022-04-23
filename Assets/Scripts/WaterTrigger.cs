using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        other.SendMessage("OnWaterEnter", SendMessageOptions.DontRequireReceiver);
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        other.SendMessage("OnWaterExit", SendMessageOptions.DontRequireReceiver);        
    }
}
