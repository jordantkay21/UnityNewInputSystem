//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/ChargeBar/Input/UIInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @UIInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @UIInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UIInputActions"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""d9184f79-1f85-425b-9009-ebf837e9541b"",
            ""actions"": [
                {
                    ""name"": ""ChargeBar"",
                    ""type"": ""Button"",
                    ""id"": ""1cf5d731-b7d0-48ca-a17e-7becffad7014"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""484f95d7-83cd-4d81-b960-4b739a429c27"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChargeBar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_ChargeBar = m_UI.FindAction("ChargeBar", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_ChargeBar;
    public struct UIActions
    {
        private @UIInputActions m_Wrapper;
        public UIActions(@UIInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChargeBar => m_Wrapper.m_UI_ChargeBar;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @ChargeBar.started -= m_Wrapper.m_UIActionsCallbackInterface.OnChargeBar;
                @ChargeBar.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnChargeBar;
                @ChargeBar.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnChargeBar;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChargeBar.started += instance.OnChargeBar;
                @ChargeBar.performed += instance.OnChargeBar;
                @ChargeBar.canceled += instance.OnChargeBar;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IUIActions
    {
        void OnChargeBar(InputAction.CallbackContext context);
    }
}