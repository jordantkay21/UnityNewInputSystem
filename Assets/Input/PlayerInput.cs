using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private PlayerInputActions _input;

    private void Start()
    {
        _input = new PlayerInputActions();
        _input.Dog.Enable();
        _input.Dog.Bark.performed += Bark_performed;
    }

    private void Bark_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Done Barking...: " + context);
    }
}
