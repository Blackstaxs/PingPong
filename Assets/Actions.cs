// GENERATED AUTOMATICALLY FROM 'Assets/Actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Actions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Actions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Actions"",
    ""maps"": [
        {
            ""name"": ""Plaver"",
            ""id"": ""6b325680-fa46-4798-aa38-b853d73c6cdd"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""3f21c627-ed46-4b28-8d97-5dbd6d52c164"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""p1"",
                    ""id"": ""a5a08602-3ea4-411f-b669-e40075115f12"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9dc6f84e-e01e-4b4d-af3a-27359e7b4c23"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4726708a-870b-498d-ab5e-82d80bbf862e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""p2"",
                    ""id"": ""fcd7b16b-f1ea-4996-995b-1241889b64b8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7baf3b06-6687-4b7f-98ca-d05c03e2a978"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6a834be2-72bc-4d91-8dee-d76f5211382d"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9ebec619-e0c9-4fd6-801c-24e75495b759"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a27573a1-f45e-4e9c-be93-cedd4ca2d9cc"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Plaver
        m_Plaver = asset.FindActionMap("Plaver", throwIfNotFound: true);
        m_Plaver_Movement = m_Plaver.FindAction("Movement", throwIfNotFound: true);
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

    // Plaver
    private readonly InputActionMap m_Plaver;
    private IPlaverActions m_PlaverActionsCallbackInterface;
    private readonly InputAction m_Plaver_Movement;
    public struct PlaverActions
    {
        private @Actions m_Wrapper;
        public PlaverActions(@Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Plaver_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Plaver; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlaverActions set) { return set.Get(); }
        public void SetCallbacks(IPlaverActions instance)
        {
            if (m_Wrapper.m_PlaverActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlaverActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlaverActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlaverActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlaverActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlaverActions @Plaver => new PlaverActions(this);
    public interface IPlaverActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
