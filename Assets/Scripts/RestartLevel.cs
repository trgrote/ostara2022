using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    [SerializeField] rho.SceneReference _scene;

    // Update is called once per frame
    public void Restart(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            SceneManager.LoadScene(_scene);
        }
    }
}
