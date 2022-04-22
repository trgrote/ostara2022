using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageSender : MonoBehaviour
{
    [SerializeField] string _message;

    // Start is called before the first frame update
    public void SendMessageToObject(GameObject other)
    {
        other.SendMessage(_message, SendMessageOptions.DontRequireReceiver);
    }
}
