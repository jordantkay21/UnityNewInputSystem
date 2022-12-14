//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/ColorChange/Input/CubeInputAction.inputactions
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

public partial class @CubeInputAction : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CubeInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CubeInputAction"",
    ""maps"": [
        {
            ""name"": ""Cube"",
            ""id"": ""4a276bb6-daa4-4893-8087-c30b5a1ae212"",
            ""actions"": [
                {
                    ""name"": ""ColorChange"",
                    ""type"": ""Button"",
                    ""id"": ""14fe5158-ff41-40c7-950a-a1f69bf87b28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""454311ed-e2d3-4f78-bdaa-189f9cc41fb7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ColorChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Cube
        m_Cube = asset.FindActionMap("Cube", throwIfNotFound: true);
        m_Cube_ColorChange = m_Cube.FindAction("ColorChange", throwIfNotFound: true);
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

    // Cube
    private readonly InputActionMap m_Cube;
    private ICubeActions m_CubeActionsCallbackInterface;
    private readonly InputAction m_Cube_ColorChange;
    public struct CubeActions
    {
        private @CubeInputAction m_Wrapper;
        public CubeActions(@CubeInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @ColorChange => m_Wrapper.m_Cube_ColorChange;
        public InputActionMap Get() { return m_Wrapper.m_Cube; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CubeActions set) { return set.Get(); }
        public void SetCallbacks(ICubeActions instance)
        {
            if (m_Wrapper.m_CubeActionsCallbackInterface != null)
            {
                @ColorChange.started -= m_Wrapper.m_CubeActionsCallbackInterface.OnColorChange;
                @ColorChange.performed -= m_Wrapper.m_CubeActionsCallbackInterface.OnColorChange;
                @ColorChange.canceled -= m_Wrapper.m_CubeActionsCallbackInterface.OnColorChange;
            }
            m_Wrapper.m_CubeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ColorChange.started += instance.OnColorChange;
                @ColorChange.performed += instance.OnColorChange;
                @ColorChange.canceled += instance.OnColorChange;
            }
        }
    }
    public CubeActions @Cube => new CubeActions(this);
    public interface ICubeActions
    {
        void OnColorChange(InputAction.CallbackContext context);
    }
}
