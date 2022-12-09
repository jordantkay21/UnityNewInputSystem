using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInput : MonoBehaviour
{
    private SphereInputAsset _input;
    
    // Start is called before the first frame update
    void Start()
    {
        _input = new SphereInputAsset();

        _input.Sphere.Enable();
        _input.Sphere.Jump.performed += Jump_performed;
        _input.Sphere.Jump.canceled += Jump_canceled;
    }

    private void Jump_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        var forceEffect = context.duration;
        GetComponent<Rigidbody>().AddForce(Vector3.up * (10f * (float)forceEffect), ForceMode.Impulse);
    }

    private void Jump_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
