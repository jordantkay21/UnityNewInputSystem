using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private PlayerInputAsset _input;
    
    // Start is called before the first frame update
    void Start()
    {
        _input = new PlayerInputAsset();

        _input.ColorChange.Enable();

        _input.ColorChange.ChangeColor.performed += ChangeColor_performed;
        _input.ColorChange.WalkingState.performed += WalkingState_performed;

        _input.Walking.ColorChangeState.performed += ColorChangeState_performed;
    }
  
    private void ColorChangeState_performed(InputAction.CallbackContext context)
    {
        _input.Walking.Disable();
        _input.ColorChange.Enable();
    }

    private void WalkingState_performed(InputAction.CallbackContext context)
    {
        _input.ColorChange.Disable();
        _input.Walking.Enable();
    }

    private void ChangeColor_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    void Update()
    {
        float rotateDirection = _input.ColorChange.Rotation.ReadValue<float>();
        transform.Rotate(Vector3.up * Time.deltaTime * 30f * rotateDirection);

        Vector2 move = _input.Walking.Movement.ReadValue<Vector2>();
        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime * 3.0f);
    }

}


