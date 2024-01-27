using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    private bool isThrowing;

    void Awake()
    {
        isThrowing = false;
    }

    public void ThrowInputHandler(InputAction.CallbackContext callback)
    {
        if (callback.performed)
        {
            Vector3 screenPos = Mouse.current.position.ReadValue();
            
        }
    }

    void Throw(Vector3 tarpos)
    {

    }
}
