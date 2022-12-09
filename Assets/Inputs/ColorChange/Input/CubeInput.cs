using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CubeInput : MonoBehaviour
{

    private CubeInputAction _input;


    // Start is called before the first frame update
    void Start()
    {
        _input = new CubeInputAction();
        _input.Cube.Enable();

        _input.Cube.ColorChange.performed += ColorChange_performed;
        
    }

    private void ColorChange_performed(InputAction.CallbackContext context)
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
