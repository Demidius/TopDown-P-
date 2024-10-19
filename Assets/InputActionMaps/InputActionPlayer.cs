//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputActionMaps/InputActionPlayer.inputactions
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

namespace InputActionsMaps
{
    public partial class @InputActionPlayer: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputActionPlayer()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActionPlayer"",
    ""maps"": [
        {
            ""name"": ""PlayerActions"",
            ""id"": ""1ca12978-9431-4518-aed0-0338c9bde829"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1a25baa1-5d99-4d65-a249-07b67b393655"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Mosuse"",
                    ""type"": ""Value"",
                    ""id"": ""518522c8-f587-49f3-9333-a6c497bb55ce"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""4ba1208b-516c-4135-8324-e36b01f45ea6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""286f4016-9e73-46b0-a9e5-a0c3351a431e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e28243ed-fd69-42da-b558-16356e3badd4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""60844437-ea4f-4deb-9b13-9535ce9ca3d7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""66873310-d717-41d9-a46b-06b60b2baffd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3da7cd7b-b0f1-4a22-b6bb-604a85f241e0"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mosuse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""AbilitiesActions"",
            ""id"": ""e916a3ba-1422-492a-b0a2-fc89bc1a877b"",
            ""actions"": [
                {
                    ""name"": ""TimeFreeze"",
                    ""type"": ""Button"",
                    ""id"": ""5e1ef71b-320a-42e6-a6cc-1a2f50e3f913"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4b8178c7-e14e-487a-bf0f-fa5133164af5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TimeFreeze"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerActions
            m_PlayerActions = asset.FindActionMap("PlayerActions", throwIfNotFound: true);
            m_PlayerActions_Move = m_PlayerActions.FindAction("Move", throwIfNotFound: true);
            m_PlayerActions_Mosuse = m_PlayerActions.FindAction("Mosuse", throwIfNotFound: true);
            // AbilitiesActions
            m_AbilitiesActions = asset.FindActionMap("AbilitiesActions", throwIfNotFound: true);
            m_AbilitiesActions_TimeFreeze = m_AbilitiesActions.FindAction("TimeFreeze", throwIfNotFound: true);
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

        // PlayerActions
        private readonly InputActionMap m_PlayerActions;
        private List<IPlayerActionsActions> m_PlayerActionsActionsCallbackInterfaces = new List<IPlayerActionsActions>();
        private readonly InputAction m_PlayerActions_Move;
        private readonly InputAction m_PlayerActions_Mosuse;
        public struct PlayerActionsActions
        {
            private @InputActionPlayer m_Wrapper;
            public PlayerActionsActions(@InputActionPlayer wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_PlayerActions_Move;
            public InputAction @Mosuse => m_Wrapper.m_PlayerActions_Mosuse;
            public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
            public void AddCallbacks(IPlayerActionsActions instance)
            {
                if (instance == null || m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Add(instance);
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Mosuse.started += instance.OnMosuse;
                @Mosuse.performed += instance.OnMosuse;
                @Mosuse.canceled += instance.OnMosuse;
            }

            private void UnregisterCallbacks(IPlayerActionsActions instance)
            {
                @Move.started -= instance.OnMove;
                @Move.performed -= instance.OnMove;
                @Move.canceled -= instance.OnMove;
                @Mosuse.started -= instance.OnMosuse;
                @Mosuse.performed -= instance.OnMosuse;
                @Mosuse.canceled -= instance.OnMosuse;
            }

            public void RemoveCallbacks(IPlayerActionsActions instance)
            {
                if (m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IPlayerActionsActions instance)
            {
                foreach (var item in m_Wrapper.m_PlayerActionsActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_PlayerActionsActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);

        // AbilitiesActions
        private readonly InputActionMap m_AbilitiesActions;
        private List<IAbilitiesActionsActions> m_AbilitiesActionsActionsCallbackInterfaces = new List<IAbilitiesActionsActions>();
        private readonly InputAction m_AbilitiesActions_TimeFreeze;
        public struct AbilitiesActionsActions
        {
            private @InputActionPlayer m_Wrapper;
            public AbilitiesActionsActions(@InputActionPlayer wrapper) { m_Wrapper = wrapper; }
            public InputAction @TimeFreeze => m_Wrapper.m_AbilitiesActions_TimeFreeze;
            public InputActionMap Get() { return m_Wrapper.m_AbilitiesActions; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(AbilitiesActionsActions set) { return set.Get(); }
            public void AddCallbacks(IAbilitiesActionsActions instance)
            {
                if (instance == null || m_Wrapper.m_AbilitiesActionsActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_AbilitiesActionsActionsCallbackInterfaces.Add(instance);
                @TimeFreeze.started += instance.OnTimeFreeze;
                @TimeFreeze.performed += instance.OnTimeFreeze;
                @TimeFreeze.canceled += instance.OnTimeFreeze;
            }

            private void UnregisterCallbacks(IAbilitiesActionsActions instance)
            {
                @TimeFreeze.started -= instance.OnTimeFreeze;
                @TimeFreeze.performed -= instance.OnTimeFreeze;
                @TimeFreeze.canceled -= instance.OnTimeFreeze;
            }

            public void RemoveCallbacks(IAbilitiesActionsActions instance)
            {
                if (m_Wrapper.m_AbilitiesActionsActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IAbilitiesActionsActions instance)
            {
                foreach (var item in m_Wrapper.m_AbilitiesActionsActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_AbilitiesActionsActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public AbilitiesActionsActions @AbilitiesActions => new AbilitiesActionsActions(this);
        public interface IPlayerActionsActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnMosuse(InputAction.CallbackContext context);
        }
        public interface IAbilitiesActionsActions
        {
            void OnTimeFreeze(InputAction.CallbackContext context);
        }
    }
}
