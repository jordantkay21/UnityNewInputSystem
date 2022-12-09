using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Input : MonoBehaviour
{
    private Cube2InputAsset _input;

    // Start is called before the first frame update
    void Start()
    {
        _input = new Cube2InputAsset();
        _input.Cube.Enable();
    }


    // Update is called once per frame
    void Update()
    {
        float rotateDirection = _input.Cube.Rotate.ReadValue<float>();

        transform.Rotate(Vector3.up * Time.deltaTime * 30f * rotateDirection);
    }
}
