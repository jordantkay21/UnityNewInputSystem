using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ChargeBar : MonoBehaviour
{
    private UIInputActions _input;

    [SerializeField]
    private Slider _slider;

    private bool _isCharging = false;

    // Start is called before the first frame update
    void Start()
    {
        _input = new UIInputActions();
        _input.UI.Enable();

        _input.UI.ChargeBar.started += ChargeBar_started;
        _input.UI.ChargeBar.canceled += ChargeBar_canceled;
    }

    private void ChargeBar_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _isCharging = false;

        Debug.Log("Charging Complete");
    }

    private void ChargeBar_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _isCharging = true;
        StartCoroutine(ChargeBarRoutine());
        Debug.Log("Charging...");
    }

    IEnumerator ChargeBarRoutine()
    {
        while (_isCharging == true)
        {
            _slider.value += (1.0f * Time.deltaTime) / 5.0f;
            yield return null;
        }

        while (_slider.value > 0)
        {
            _slider.value -= 1.0f * Time.deltaTime;
            yield return null;
        }
    }
}
