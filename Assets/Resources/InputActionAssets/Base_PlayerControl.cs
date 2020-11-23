// GENERATED AUTOMATICALLY FROM 'Assets/Resources/InputActionAssets/Base_PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Base_PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Base_PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Base_PlayerControl"",
    ""maps"": [
        {
            ""name"": ""MainCharacter"",
            ""id"": ""3eaf92f6-011a-4aa4-8edd-edc32d8788da"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5ca02805-3aa0-43eb-9ade-23a1af240b86"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookAround"",
                    ""type"": ""Value"",
                    ""id"": ""5ac02ec1-2a47-4067-ba6e-192c85286d10"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""34ea9ed3-ab65-45b5-b72b-9035df6c92d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""41c11246-1b46-49f6-a3f9-d26f6717af95"",
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
                    ""id"": ""0c34584e-1503-4813-8b7a-360adc7c1c6c"",
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
                    ""id"": ""56688f28-84d0-464b-973c-06eb5486cf22"",
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
                    ""id"": ""f5165abc-875f-4e79-b260-209e83e6b8d4"",
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
                    ""id"": ""a79dcb63-0ca9-495b-802e-084f4759ca63"",
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
                    ""id"": ""c9dbb3a5-b9cb-4709-a30e-a10ac7830a0c"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=5,y=5)"",
                    ""groups"": """",
                    ""action"": ""LookAround"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07decf7f-5fbb-4cca-9a88-649ebe99c011"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MainCharacter
        m_MainCharacter = asset.FindActionMap("MainCharacter", throwIfNotFound: true);
        m_MainCharacter_Move = m_MainCharacter.FindAction("Move", throwIfNotFound: true);
        m_MainCharacter_LookAround = m_MainCharacter.FindAction("LookAround", throwIfNotFound: true);
        m_MainCharacter_Jump = m_MainCharacter.FindAction("Jump", throwIfNotFound: true);
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

    // MainCharacter
    private readonly InputActionMap m_MainCharacter;
    private IMainCharacterActions m_MainCharacterActionsCallbackInterface;
    private readonly InputAction m_MainCharacter_Move;
    private readonly InputAction m_MainCharacter_LookAround;
    private readonly InputAction m_MainCharacter_Jump;
    public struct MainCharacterActions
    {
        private @Base_PlayerControl m_Wrapper;
        public MainCharacterActions(@Base_PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MainCharacter_Move;
        public InputAction @LookAround => m_Wrapper.m_MainCharacter_LookAround;
        public InputAction @Jump => m_Wrapper.m_MainCharacter_Jump;
        public InputActionMap Get() { return m_Wrapper.m_MainCharacter; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainCharacterActions set) { return set.Get(); }
        public void SetCallbacks(IMainCharacterActions instance)
        {
            if (m_Wrapper.m_MainCharacterActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MainCharacterActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MainCharacterActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MainCharacterActionsCallbackInterface.OnMove;
                @LookAround.started -= m_Wrapper.m_MainCharacterActionsCallbackInterface.OnLookAround;
                @LookAround.performed -= m_Wrapper.m_MainCharacterActionsCallbackInterface.OnLookAround;
                @LookAround.canceled -= m_Wrapper.m_MainCharacterActionsCallbackInterface.OnLookAround;
                @Jump.started -= m_Wrapper.m_MainCharacterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MainCharacterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MainCharacterActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_MainCharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @LookAround.started += instance.OnLookAround;
                @LookAround.performed += instance.OnLookAround;
                @LookAround.canceled += instance.OnLookAround;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public MainCharacterActions @MainCharacter => new MainCharacterActions(this);
    public interface IMainCharacterActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLookAround(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
