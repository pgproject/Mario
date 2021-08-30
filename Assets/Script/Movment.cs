// GENERATED AUTOMATICALLY FROM 'Assets/Prefab/Movment.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Movment
{
    public class @Movment : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Movment()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Movment"",
    ""maps"": [
        {
            ""name"": ""Normal"",
            ""id"": ""9d3ba908-d3e7-4145-a205-cbafccbe96bd"",
            ""actions"": [
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""66ddc1fc-e5b1-4f3b-a799-3229c0e09525"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""a493c5f1-2c88-4486-84b6-d8b7442530d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""040f0730-5a64-4832-8bd5-694ce22625ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GoDown"",
                    ""type"": ""Button"",
                    ""id"": ""c7e7f5ef-0a8f-45f4-a748-a0095115da1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""2fff5d84-3947-40da-99c7-6c9d24f599f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c17a2dfc-839e-405b-8164-0459958046ce"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32c3cd9a-ef46-49de-bd2a-a453bb23542b"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10836628-8b21-479a-afea-344f533119d6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3b30765-f786-4be1-92de-ad8cecec360a"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a724427-9567-44c8-8ee2-722831867420"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e48feaa4-24be-44a9-a9ca-6cc1ff4c226b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5c2290c-c3d9-4571-b599-bd657a622b30"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9643733-3345-47b4-8ec5-b279148122f0"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c23fda9d-41a3-474a-90bc-749f199a06a9"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""130ab57c-eee0-44f2-b82a-129c8dd6bce7"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Movment"",
            ""bindingGroup"": ""Movment"",
            ""devices"": []
        }
    ]
}");
            // Normal
            m_Normal = asset.FindActionMap("Normal", throwIfNotFound: true);
            m_Normal_MoveLeft = m_Normal.FindAction("MoveLeft", throwIfNotFound: true);
            m_Normal_MoveRight = m_Normal.FindAction("MoveRight", throwIfNotFound: true);
            m_Normal_Jump = m_Normal.FindAction("Jump", throwIfNotFound: true);
            m_Normal_GoDown = m_Normal.FindAction("GoDown", throwIfNotFound: true);
            m_Normal_Interact = m_Normal.FindAction("Interact", throwIfNotFound: true);
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

        // Normal
        private readonly InputActionMap m_Normal;
        private INormalActions m_NormalActionsCallbackInterface;
        private readonly InputAction m_Normal_MoveLeft;
        private readonly InputAction m_Normal_MoveRight;
        private readonly InputAction m_Normal_Jump;
        private readonly InputAction m_Normal_GoDown;
        private readonly InputAction m_Normal_Interact;
        public struct NormalActions
        {
            private @Movment m_Wrapper;
            public NormalActions(@Movment wrapper) { m_Wrapper = wrapper; }
            public InputAction @MoveLeft => m_Wrapper.m_Normal_MoveLeft;
            public InputAction @MoveRight => m_Wrapper.m_Normal_MoveRight;
            public InputAction @Jump => m_Wrapper.m_Normal_Jump;
            public InputAction @GoDown => m_Wrapper.m_Normal_GoDown;
            public InputAction @Interact => m_Wrapper.m_Normal_Interact;
            public InputActionMap Get() { return m_Wrapper.m_Normal; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(NormalActions set) { return set.Get(); }
            public void SetCallbacks(INormalActions instance)
            {
                if (m_Wrapper.m_NormalActionsCallbackInterface != null)
                {
                    @MoveLeft.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnMoveLeft;
                    @MoveLeft.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnMoveLeft;
                    @MoveLeft.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnMoveLeft;
                    @MoveRight.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnMoveRight;
                    @MoveRight.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnMoveRight;
                    @MoveRight.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnMoveRight;
                    @Jump.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                    @GoDown.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnGoDown;
                    @GoDown.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnGoDown;
                    @GoDown.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnGoDown;
                    @Interact.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnInteract;
                    @Interact.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnInteract;
                    @Interact.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnInteract;
                }
                m_Wrapper.m_NormalActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MoveLeft.started += instance.OnMoveLeft;
                    @MoveLeft.performed += instance.OnMoveLeft;
                    @MoveLeft.canceled += instance.OnMoveLeft;
                    @MoveRight.started += instance.OnMoveRight;
                    @MoveRight.performed += instance.OnMoveRight;
                    @MoveRight.canceled += instance.OnMoveRight;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @GoDown.started += instance.OnGoDown;
                    @GoDown.performed += instance.OnGoDown;
                    @GoDown.canceled += instance.OnGoDown;
                    @Interact.started += instance.OnInteract;
                    @Interact.performed += instance.OnInteract;
                    @Interact.canceled += instance.OnInteract;
                }
            }
        }
        public NormalActions @Normal => new NormalActions(this);
        private int m_MovmentSchemeIndex = -1;
        public InputControlScheme MovmentScheme
        {
            get
            {
                if (m_MovmentSchemeIndex == -1) m_MovmentSchemeIndex = asset.FindControlSchemeIndex("Movment");
                return asset.controlSchemes[m_MovmentSchemeIndex];
            }
        }
        public interface INormalActions
        {
            void OnMoveLeft(InputAction.CallbackContext context);
            void OnMoveRight(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnGoDown(InputAction.CallbackContext context);
            void OnInteract(InputAction.CallbackContext context);
        }
    }
}
