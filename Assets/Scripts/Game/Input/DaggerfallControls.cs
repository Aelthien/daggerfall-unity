// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Game/Input/DaggerfallControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DaggerfallControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DaggerfallControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DaggerfallControls"",
    ""maps"": [
        {
            ""name"": ""KeyboardMouse"",
            ""id"": ""d6551b00-30d1-49b6-a8ae-c2f8dc88d920"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""2ac8be6f-ff5b-4026-8740-2af0352b3e64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""66971fc8-8317-41fa-9f2f-44a11c5b559f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""f6253aa1-4a52-4c68-a7c3-ef7632fff68e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""db1d1ab8-f36d-4a72-a1f6-5ab9f0ad9cdd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""f2e59a64-641a-4cd7-967e-160f9c42a468"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""34cfd0f2-5c63-413b-b654-fb5538d23458"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""94ae3f2f-8c53-4528-9ac9-fe0d0293f132"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""CharacterSheet"",
                    ""type"": ""Button"",
                    ""id"": ""036adc1b-cc59-42e6-918f-8517a9f417dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rest"",
                    ""type"": ""Button"",
                    ""id"": ""cb305b04-dd2f-4f1c-8ee4-602a674a3819"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Transport"",
                    ""type"": ""Button"",
                    ""id"": ""8ac318cc-eb17-4264-bc4f-0022e8d7d6dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Float"",
                    ""type"": ""Button"",
                    ""id"": ""558f1aa8-cbdb-4a1b-ab7d-c84e6ead23f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""ef23d7af-e2d1-430c-b62e-26981e9749b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Status"",
                    ""type"": ""Button"",
                    ""id"": ""31cb5c5f-a29a-4d02-9e14-c8eef3d03fb1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""b4a827c9-3fba-4229-b54e-0ae6e3adb437"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AbortSpell"",
                    ""type"": ""Button"",
                    ""id"": ""242287be-dad7-414b-8078-0781a9e3d13d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TransportFoot"",
                    ""type"": ""Button"",
                    ""id"": ""3aa6eaae-435b-42e9-9dba-5afd8b39bc2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TransportHorse"",
                    ""type"": ""Button"",
                    ""id"": ""944677f3-0a0d-47da-8ed6-383e3efe18fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TransportShip"",
                    ""type"": ""Button"",
                    ""id"": ""8c92f6af-502b-40c8-8d12-417b28cc5b49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""7d2099a7-2c93-4c42-bfaa-7327104a8300"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TravelMapFind"",
                    ""type"": ""Button"",
                    ""id"": ""193121b8-4657-4c55-8639-cb2f22e929a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TravelMapList"",
                    ""type"": ""Button"",
                    ""id"": ""a0e890c6-b5c6-490f-bf91-f6a7a26d3dd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""201ac2ae-d175-44ad-b0fe-6aa7d2f36e0f"",
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
                    ""id"": ""71062a30-09d4-4824-91e5-00640720a827"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ad49a40e-8859-4565-bc75-357b1d46fc48"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""46293078-6f8b-4f40-868a-7e4ba0df8a0e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f4af6c50-a3f9-4a71-b251-9ac2675ccb08"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3bca5a23-de60-4d40-a952-d224d46fdcef"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cadb7ac9-a7ec-4c20-95fc-25eb0e8d9bfa"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b12b80cf-1aff-45a6-bc50-bbc8276ae68e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec965de8-d496-481a-9413-1ab1744c0b1f"",
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
                    ""id"": ""d8032c11-c8ed-4f0c-a699-7e52171da9f8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34f27150-1169-402e-9cd3-79bde5bd0a68"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0adcc64a-9a23-4921-a685-7c272e99ec97"",
                    ""path"": ""<Keyboard>/f5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CharacterSheet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e6cf8c8-dea8-4319-b354-0797313a164c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5783c893-5b9d-4c19-9e7e-ad49355880f3"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Transport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8893ee6f-760e-4553-bc82-8375841a0f53"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Float"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""27d01f0a-b920-42ec-882c-8c23ef7b553a"",
                    ""path"": ""<Keyboard>/pageDown"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Float"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b83724e6-567f-480b-ae9c-21e84f22944f"",
                    ""path"": ""<Keyboard>/pageUp"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Float"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""29ddeb31-4fd4-4130-a1a1-6b0ed0d51e48"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eac62cad-2439-4b4c-91ac-9ff6f7cbab7a"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Status"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""044579ed-c092-45e2-8444-e52769074dcc"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f214c52-1e2e-4a38-a5bb-858cdb6088f7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AbortSpell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5be6c1de-82b9-4aa1-ae47-5a74a89c5279"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TransportFoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43f53489-dc2a-4745-b002-b074834bff6a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TransportHorse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e14c551-8096-4cfc-9219-44737d2d5db2"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TransportShip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""dee37906-8147-4c31-a2a2-00a11b0a12da"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""fbb8b708-dd0e-4525-bd4b-e3a03d78d140"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""badaacbe-3495-449d-85df-2428bfbe3ab8"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8577b174-2e2a-4ef3-998d-6d354ab868d2"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TravelMapFind"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d84a0c50-6ffc-4f40-bf55-bac0a9f8d662"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TravelMapList"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": []
        }
    ]
}");
        // KeyboardMouse
        m_KeyboardMouse = asset.FindActionMap("KeyboardMouse", throwIfNotFound: true);
        m_KeyboardMouse_Movement = m_KeyboardMouse.FindAction("Movement", throwIfNotFound: true);
        m_KeyboardMouse_Fire = m_KeyboardMouse.FindAction("Fire", throwIfNotFound: true);
        m_KeyboardMouse_Submit = m_KeyboardMouse.FindAction("Submit", throwIfNotFound: true);
        m_KeyboardMouse_Cancel = m_KeyboardMouse.FindAction("Cancel", throwIfNotFound: true);
        m_KeyboardMouse_Aim = m_KeyboardMouse.FindAction("Aim", throwIfNotFound: true);
        m_KeyboardMouse_Jump = m_KeyboardMouse.FindAction("Jump", throwIfNotFound: true);
        m_KeyboardMouse_Inventory = m_KeyboardMouse.FindAction("Inventory", throwIfNotFound: true);
        m_KeyboardMouse_CharacterSheet = m_KeyboardMouse.FindAction("CharacterSheet", throwIfNotFound: true);
        m_KeyboardMouse_Rest = m_KeyboardMouse.FindAction("Rest", throwIfNotFound: true);
        m_KeyboardMouse_Transport = m_KeyboardMouse.FindAction("Transport", throwIfNotFound: true);
        m_KeyboardMouse_Float = m_KeyboardMouse.FindAction("Float", throwIfNotFound: true);
        m_KeyboardMouse_Crouch = m_KeyboardMouse.FindAction("Crouch", throwIfNotFound: true);
        m_KeyboardMouse_Status = m_KeyboardMouse.FindAction("Status", throwIfNotFound: true);
        m_KeyboardMouse_Run = m_KeyboardMouse.FindAction("Run", throwIfNotFound: true);
        m_KeyboardMouse_AbortSpell = m_KeyboardMouse.FindAction("AbortSpell", throwIfNotFound: true);
        m_KeyboardMouse_TransportFoot = m_KeyboardMouse.FindAction("TransportFoot", throwIfNotFound: true);
        m_KeyboardMouse_TransportHorse = m_KeyboardMouse.FindAction("TransportHorse", throwIfNotFound: true);
        m_KeyboardMouse_TransportShip = m_KeyboardMouse.FindAction("TransportShip", throwIfNotFound: true);
        m_KeyboardMouse_MousePosition = m_KeyboardMouse.FindAction("MousePosition", throwIfNotFound: true);
        m_KeyboardMouse_TravelMapFind = m_KeyboardMouse.FindAction("TravelMapFind", throwIfNotFound: true);
        m_KeyboardMouse_TravelMapList = m_KeyboardMouse.FindAction("TravelMapList", throwIfNotFound: true);
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

    // KeyboardMouse
    private readonly InputActionMap m_KeyboardMouse;
    private IKeyboardMouseActions m_KeyboardMouseActionsCallbackInterface;
    private readonly InputAction m_KeyboardMouse_Movement;
    private readonly InputAction m_KeyboardMouse_Fire;
    private readonly InputAction m_KeyboardMouse_Submit;
    private readonly InputAction m_KeyboardMouse_Cancel;
    private readonly InputAction m_KeyboardMouse_Aim;
    private readonly InputAction m_KeyboardMouse_Jump;
    private readonly InputAction m_KeyboardMouse_Inventory;
    private readonly InputAction m_KeyboardMouse_CharacterSheet;
    private readonly InputAction m_KeyboardMouse_Rest;
    private readonly InputAction m_KeyboardMouse_Transport;
    private readonly InputAction m_KeyboardMouse_Float;
    private readonly InputAction m_KeyboardMouse_Crouch;
    private readonly InputAction m_KeyboardMouse_Status;
    private readonly InputAction m_KeyboardMouse_Run;
    private readonly InputAction m_KeyboardMouse_AbortSpell;
    private readonly InputAction m_KeyboardMouse_TransportFoot;
    private readonly InputAction m_KeyboardMouse_TransportHorse;
    private readonly InputAction m_KeyboardMouse_TransportShip;
    private readonly InputAction m_KeyboardMouse_MousePosition;
    private readonly InputAction m_KeyboardMouse_TravelMapFind;
    private readonly InputAction m_KeyboardMouse_TravelMapList;
    public struct KeyboardMouseActions
    {
        private @DaggerfallControls m_Wrapper;
        public KeyboardMouseActions(@DaggerfallControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_KeyboardMouse_Movement;
        public InputAction @Fire => m_Wrapper.m_KeyboardMouse_Fire;
        public InputAction @Submit => m_Wrapper.m_KeyboardMouse_Submit;
        public InputAction @Cancel => m_Wrapper.m_KeyboardMouse_Cancel;
        public InputAction @Aim => m_Wrapper.m_KeyboardMouse_Aim;
        public InputAction @Jump => m_Wrapper.m_KeyboardMouse_Jump;
        public InputAction @Inventory => m_Wrapper.m_KeyboardMouse_Inventory;
        public InputAction @CharacterSheet => m_Wrapper.m_KeyboardMouse_CharacterSheet;
        public InputAction @Rest => m_Wrapper.m_KeyboardMouse_Rest;
        public InputAction @Transport => m_Wrapper.m_KeyboardMouse_Transport;
        public InputAction @Float => m_Wrapper.m_KeyboardMouse_Float;
        public InputAction @Crouch => m_Wrapper.m_KeyboardMouse_Crouch;
        public InputAction @Status => m_Wrapper.m_KeyboardMouse_Status;
        public InputAction @Run => m_Wrapper.m_KeyboardMouse_Run;
        public InputAction @AbortSpell => m_Wrapper.m_KeyboardMouse_AbortSpell;
        public InputAction @TransportFoot => m_Wrapper.m_KeyboardMouse_TransportFoot;
        public InputAction @TransportHorse => m_Wrapper.m_KeyboardMouse_TransportHorse;
        public InputAction @TransportShip => m_Wrapper.m_KeyboardMouse_TransportShip;
        public InputAction @MousePosition => m_Wrapper.m_KeyboardMouse_MousePosition;
        public InputAction @TravelMapFind => m_Wrapper.m_KeyboardMouse_TravelMapFind;
        public InputAction @TravelMapList => m_Wrapper.m_KeyboardMouse_TravelMapList;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardMouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardMouseActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardMouseActions instance)
        {
            if (m_Wrapper.m_KeyboardMouseActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMovement;
                @Fire.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnFire;
                @Submit.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnCancel;
                @Aim.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnAim;
                @Jump.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnJump;
                @Inventory.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnInventory;
                @CharacterSheet.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnCharacterSheet;
                @CharacterSheet.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnCharacterSheet;
                @CharacterSheet.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnCharacterSheet;
                @Rest.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnRest;
                @Rest.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnRest;
                @Rest.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnRest;
                @Transport.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTransport;
                @Transport.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTransport;
                @Transport.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTransport;
                @Float.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnFloat;
                @Float.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnFloat;
                @Float.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnFloat;
                @Crouch.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnCrouch;
                @Status.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnStatus;
                @Status.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnStatus;
                @Status.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnStatus;
                @Run.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnRun;
                @AbortSpell.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnAbortSpell;
                @AbortSpell.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnAbortSpell;
                @AbortSpell.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnAbortSpell;
                @TransportFoot.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTransportFoot;
                @TransportFoot.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTransportFoot;
                @TransportFoot.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTransportFoot;
                @TransportHorse.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTransportHorse;
                @TransportHorse.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTransportHorse;
                @TransportHorse.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTransportHorse;
                @TransportShip.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTransportShip;
                @TransportShip.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTransportShip;
                @TransportShip.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTransportShip;
                @MousePosition.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMousePosition;
                @TravelMapFind.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTravelMapFind;
                @TravelMapFind.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTravelMapFind;
                @TravelMapFind.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTravelMapFind;
                @TravelMapList.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTravelMapList;
                @TravelMapList.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTravelMapList;
                @TravelMapList.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTravelMapList;
            }
            m_Wrapper.m_KeyboardMouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @CharacterSheet.started += instance.OnCharacterSheet;
                @CharacterSheet.performed += instance.OnCharacterSheet;
                @CharacterSheet.canceled += instance.OnCharacterSheet;
                @Rest.started += instance.OnRest;
                @Rest.performed += instance.OnRest;
                @Rest.canceled += instance.OnRest;
                @Transport.started += instance.OnTransport;
                @Transport.performed += instance.OnTransport;
                @Transport.canceled += instance.OnTransport;
                @Float.started += instance.OnFloat;
                @Float.performed += instance.OnFloat;
                @Float.canceled += instance.OnFloat;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Status.started += instance.OnStatus;
                @Status.performed += instance.OnStatus;
                @Status.canceled += instance.OnStatus;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @AbortSpell.started += instance.OnAbortSpell;
                @AbortSpell.performed += instance.OnAbortSpell;
                @AbortSpell.canceled += instance.OnAbortSpell;
                @TransportFoot.started += instance.OnTransportFoot;
                @TransportFoot.performed += instance.OnTransportFoot;
                @TransportFoot.canceled += instance.OnTransportFoot;
                @TransportHorse.started += instance.OnTransportHorse;
                @TransportHorse.performed += instance.OnTransportHorse;
                @TransportHorse.canceled += instance.OnTransportHorse;
                @TransportShip.started += instance.OnTransportShip;
                @TransportShip.performed += instance.OnTransportShip;
                @TransportShip.canceled += instance.OnTransportShip;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @TravelMapFind.started += instance.OnTravelMapFind;
                @TravelMapFind.performed += instance.OnTravelMapFind;
                @TravelMapFind.canceled += instance.OnTravelMapFind;
                @TravelMapList.started += instance.OnTravelMapList;
                @TravelMapList.performed += instance.OnTravelMapList;
                @TravelMapList.canceled += instance.OnTravelMapList;
            }
        }
    }
    public KeyboardMouseActions @KeyboardMouse => new KeyboardMouseActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface IKeyboardMouseActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnCharacterSheet(InputAction.CallbackContext context);
        void OnRest(InputAction.CallbackContext context);
        void OnTransport(InputAction.CallbackContext context);
        void OnFloat(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnStatus(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnAbortSpell(InputAction.CallbackContext context);
        void OnTransportFoot(InputAction.CallbackContext context);
        void OnTransportHorse(InputAction.CallbackContext context);
        void OnTransportShip(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnTravelMapFind(InputAction.CallbackContext context);
        void OnTravelMapList(InputAction.CallbackContext context);
    }
}
