//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Plugins/UnityInput/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gun"",
            ""id"": ""0427f45c-ce4b-489b-b4ec-18d46ed99449"",
            ""actions"": [
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""92924909-f401-4ada-b627-d80c8cf83a3b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""e329acf7-0a6b-4089-8ddd-052cff6de12a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""780388a1-62e7-4df3-ae93-c2e3018e9bc6"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f296ac0a-b950-4249-86fe-df8aecf43211"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gunner Control Scheme"",
            ""bindingGroup"": ""Gunner Control Scheme"",
            ""devices"": []
        }
    ]
}");
        // Gun
        m_Gun = asset.FindActionMap("Gun", throwIfNotFound: true);
        m_Gun_Aim = m_Gun.FindAction("Aim", throwIfNotFound: true);
        m_Gun_Fire = m_Gun.FindAction("Fire", throwIfNotFound: true);
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

    // Gun
    private readonly InputActionMap m_Gun;
    private IGunActions m_GunActionsCallbackInterface;
    private readonly InputAction m_Gun_Aim;
    private readonly InputAction m_Gun_Fire;
    public struct GunActions
    {
        private @PlayerControls m_Wrapper;
        public GunActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Aim => m_Wrapper.m_Gun_Aim;
        public InputAction @Fire => m_Wrapper.m_Gun_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Gun; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GunActions set) { return set.Get(); }
        public void SetCallbacks(IGunActions instance)
        {
            if (m_Wrapper.m_GunActionsCallbackInterface != null)
            {
                @Aim.started -= m_Wrapper.m_GunActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_GunActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_GunActionsCallbackInterface.OnAim;
                @Fire.started -= m_Wrapper.m_GunActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_GunActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_GunActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_GunActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public GunActions @Gun => new GunActions(this);
    private int m_GunnerControlSchemeSchemeIndex = -1;
    public InputControlScheme GunnerControlSchemeScheme
    {
        get
        {
            if (m_GunnerControlSchemeSchemeIndex == -1) m_GunnerControlSchemeSchemeIndex = asset.FindControlSchemeIndex("Gunner Control Scheme");
            return asset.controlSchemes[m_GunnerControlSchemeSchemeIndex];
        }
    }
    public interface IGunActions
    {
        void OnAim(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
