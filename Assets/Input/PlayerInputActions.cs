//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Dog"",
            ""id"": ""cf0ad3ee-bc82-4357-9bd4-46b65cc40da6"",
            ""actions"": [
                {
                    ""name"": ""Bark"",
                    ""type"": ""Button"",
                    ""id"": ""4828319a-46c3-413b-85bd-01c7dcdbccad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""422e7e5a-0b11-46c8-a793-a49c7d82673b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""e338f273-10a1-44b2-a954-697c1375f7d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Die"",
                    ""type"": ""Button"",
                    ""id"": ""968e87bb-c52c-47c8-b121-7a812ac255af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cd673010-9dae-40ff-a6c3-9924bbc7b92f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bark"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fc2af8a8-a018-42d6-bee7-7f5176f21f6a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""78f2a991-9d6f-4636-a4fc-da7cd9fe4852"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d9ae79e4-8982-4d17-8f7f-18b31150ce18"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""91819a64-81cd-4e18-b024-7b2b191b98c7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5ebd8f94-b5bf-47b7-b1ab-28ba1739ab6a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d958c763-b34a-47c5-aeb6-a8f45a8191a5"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""a4103360-3366-4f85-8e7d-ec6626584035"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Die"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Modifier"",
                    ""id"": ""cbe88614-17ac-453d-8da4-a962d1dad235"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Die"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button"",
                    ""id"": ""bf30f7ad-2ef5-4c5d-9231-ac2ee228ea96"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Die"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Dog
        m_Dog = asset.FindActionMap("Dog", throwIfNotFound: true);
        m_Dog_Bark = m_Dog.FindAction("Bark", throwIfNotFound: true);
        m_Dog_Walk = m_Dog.FindAction("Walk", throwIfNotFound: true);
        m_Dog_Run = m_Dog.FindAction("Run", throwIfNotFound: true);
        m_Dog_Die = m_Dog.FindAction("Die", throwIfNotFound: true);
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

    // Dog
    private readonly InputActionMap m_Dog;
    private IDogActions m_DogActionsCallbackInterface;
    private readonly InputAction m_Dog_Bark;
    private readonly InputAction m_Dog_Walk;
    private readonly InputAction m_Dog_Run;
    private readonly InputAction m_Dog_Die;
    public struct DogActions
    {
        private @PlayerInputActions m_Wrapper;
        public DogActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Bark => m_Wrapper.m_Dog_Bark;
        public InputAction @Walk => m_Wrapper.m_Dog_Walk;
        public InputAction @Run => m_Wrapper.m_Dog_Run;
        public InputAction @Die => m_Wrapper.m_Dog_Die;
        public InputActionMap Get() { return m_Wrapper.m_Dog; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DogActions set) { return set.Get(); }
        public void SetCallbacks(IDogActions instance)
        {
            if (m_Wrapper.m_DogActionsCallbackInterface != null)
            {
                @Bark.started -= m_Wrapper.m_DogActionsCallbackInterface.OnBark;
                @Bark.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnBark;
                @Bark.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnBark;
                @Walk.started -= m_Wrapper.m_DogActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnWalk;
                @Run.started -= m_Wrapper.m_DogActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnRun;
                @Die.started -= m_Wrapper.m_DogActionsCallbackInterface.OnDie;
                @Die.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnDie;
                @Die.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnDie;
            }
            m_Wrapper.m_DogActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Bark.started += instance.OnBark;
                @Bark.performed += instance.OnBark;
                @Bark.canceled += instance.OnBark;
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Die.started += instance.OnDie;
                @Die.performed += instance.OnDie;
                @Die.canceled += instance.OnDie;
            }
        }
    }
    public DogActions @Dog => new DogActions(this);
    public interface IDogActions
    {
        void OnBark(InputAction.CallbackContext context);
        void OnWalk(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnDie(InputAction.CallbackContext context);
    }
}