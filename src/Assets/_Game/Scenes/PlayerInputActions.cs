// GENERATED AUTOMATICALLY FROM 'Assets/_Game/Scenes/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""LeftVRcontroller"",
            ""id"": ""c6dd8f31-53c2-4712-b779-de9398b12993"",
            ""actions"": [
                {
                    ""name"": ""Squeeze"",
                    ""type"": ""Button"",
                    ""id"": ""5b398f12-408d-485a-b56f-505d88a5e1b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grip"",
                    ""type"": ""Button"",
                    ""id"": ""ebc6a445-9c19-46a1-88ff-85e5fcb389a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackPadClick"",
                    ""type"": ""Button"",
                    ""id"": ""49e4fdf1-6a7d-44cf-a758-fdb511eb37ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackPadTouched"",
                    ""type"": ""Button"",
                    ""id"": ""55fc9f32-dc2d-4fbf-9df1-d59cd31d4844"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerPressed"",
                    ""type"": ""Button"",
                    ""id"": ""8d02d9d0-2e06-4016-b0e8-ba36e40c29fb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""IsTracked"",
                    ""type"": ""Button"",
                    ""id"": ""42be60fb-c8b9-4f19-8b1f-5499c3db3ab8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""39da8be9-3dbc-492c-8af1-02529cad0f9b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PointerIsTracked"",
                    ""type"": ""Button"",
                    ""id"": ""94322e3c-73c8-4537-9a0c-55a85c864e77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DevicePoseIsTracked"",
                    ""type"": ""Button"",
                    ""id"": ""b04154dc-255c-4003-9eec-fa4b32358df6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""fb5d0b77-a8bc-4f4a-b268-636bac56948f"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c0b0beca-d830-42a9-9d1e-e3a490d8b37e"",
                    ""path"": ""/input/trigger/squeeze"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Squeeze"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e92924ed-72dc-43c8-805b-78e9d6c78962"",
                    ""path"": ""<ViveController>/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf5fe9af-74c6-4a50-8562-d31bea2c03af"",
                    ""path"": ""<ViveController>{LeftHand}/trackpadClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrackPadClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""459923b9-e462-4980-a2c3-374e002c3fcb"",
                    ""path"": ""<ViveController>{LeftHand}/trackpadTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrackPadTouched"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c8a073a-e564-4cfb-a1f7-063b254dfef0"",
                    ""path"": ""<ViveController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0edb4992-3ec5-40cf-bf76-13075c304ee7"",
                    ""path"": ""<ViveController>{LeftHand}/isTracked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IsTracked"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7c60bab-d3cb-49f6-bdac-27b629ce0de0"",
                    ""path"": ""<ViveController>{LeftHand}/menu"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""259d19c7-c5ad-4079-b7d1-dfe7a9bca663"",
                    ""path"": ""<ViveController>{LeftHand}/pointer/isTracked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointerIsTracked"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d86ebd0-3905-4a3d-b7fe-dd9328d133f7"",
                    ""path"": ""<ViveController>{LeftHand}/devicePose/isTracked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DevicePoseIsTracked"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56a1d7dd-b31c-413d-8633-69b8bfb73c9a"",
                    ""path"": ""<XRController>{LeftHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RightVRcontroller"",
            ""id"": ""5ffb4834-00c6-48f6-bb3c-923b763e46d9"",
            ""actions"": [
                {
                    ""name"": ""GripPressed"",
                    ""type"": ""Button"",
                    ""id"": ""d808fcde-eee5-435e-8d1d-d116ff5ff978"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DevicePoseIsTracked"",
                    ""type"": ""Button"",
                    ""id"": ""41617f19-1826-414d-95a7-49f6a478f96a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""IsTracked"",
                    ""type"": ""Button"",
                    ""id"": ""220b8d1d-1773-4772-94ca-69f361c9f41c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""bb4dc936-235f-42be-a4e9-a5a0c4b17392"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PointerIsTracked"",
                    ""type"": ""Button"",
                    ""id"": ""53e2f1e7-495d-4062-b391-de205762c98c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""b9ee7161-2a1d-4871-ba3a-cc10e2b9712c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackPadClicked"",
                    ""type"": ""Button"",
                    ""id"": ""8362b6f6-3d11-475b-961e-6492da1b7e66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackPadTouched"",
                    ""type"": ""Button"",
                    ""id"": ""d77fe11e-7415-4fd3-a537-7bb5a9cd9404"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerPressed"",
                    ""type"": ""Button"",
                    ""id"": ""8f934a6f-3e08-4108-bb34-1c34bc4babaa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""3ce1107b-6d9d-404f-b961-4caed91fc164"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bc08aba2-cbb4-4b6e-94f9-9484961d8123"",
                    ""path"": ""<ViveController>{RightHand}/devicePose/isTracked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DevicePoseIsTracked"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ea0f298-1b20-475a-a784-bfaa8268c944"",
                    ""path"": ""<ViveController>{RightHand}/isTracked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IsTracked"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd80bfc7-d736-4406-8573-d541a5cc378b"",
                    ""path"": ""<ViveController>{RightHand}/menu"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c54e38b3-071e-4a9d-b2a3-d13bb93f1ca0"",
                    ""path"": ""<ViveController>{RightHand}/pointer/isTracked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointerIsTracked"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92931015-888b-418a-8411-43586ba333fe"",
                    ""path"": ""<ViveController>{RightHand}/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20417e3e-1e85-46ea-97dc-a7ebd51635d3"",
                    ""path"": ""<ViveController>{RightHand}/trackpadClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrackPadClicked"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30c1e86b-18ad-40bd-9e09-6b062ed2812d"",
                    ""path"": ""<ViveController>{RightHand}/trackpadTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TrackPadTouched"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""164ba420-9d16-4a05-834f-a5e886950f7b"",
                    ""path"": ""<ViveController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9fe6805-0611-43d9-a2cc-1ada725460c9"",
                    ""path"": ""<ViveController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GripPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""079ac08b-2a4e-4696-a95b-ffff14a6bc9d"",
                    ""path"": ""<XRController>{RightHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // LeftVRcontroller
        m_LeftVRcontroller = asset.FindActionMap("LeftVRcontroller", throwIfNotFound: true);
        m_LeftVRcontroller_Squeeze = m_LeftVRcontroller.FindAction("Squeeze", throwIfNotFound: true);
        m_LeftVRcontroller_Grip = m_LeftVRcontroller.FindAction("Grip", throwIfNotFound: true);
        m_LeftVRcontroller_TrackPadClick = m_LeftVRcontroller.FindAction("TrackPadClick", throwIfNotFound: true);
        m_LeftVRcontroller_TrackPadTouched = m_LeftVRcontroller.FindAction("TrackPadTouched", throwIfNotFound: true);
        m_LeftVRcontroller_TriggerPressed = m_LeftVRcontroller.FindAction("TriggerPressed", throwIfNotFound: true);
        m_LeftVRcontroller_IsTracked = m_LeftVRcontroller.FindAction("IsTracked", throwIfNotFound: true);
        m_LeftVRcontroller_Menu = m_LeftVRcontroller.FindAction("Menu", throwIfNotFound: true);
        m_LeftVRcontroller_PointerIsTracked = m_LeftVRcontroller.FindAction("PointerIsTracked", throwIfNotFound: true);
        m_LeftVRcontroller_DevicePoseIsTracked = m_LeftVRcontroller.FindAction("DevicePoseIsTracked", throwIfNotFound: true);
        m_LeftVRcontroller_Position = m_LeftVRcontroller.FindAction("Position", throwIfNotFound: true);
        // RightVRcontroller
        m_RightVRcontroller = asset.FindActionMap("RightVRcontroller", throwIfNotFound: true);
        m_RightVRcontroller_GripPressed = m_RightVRcontroller.FindAction("GripPressed", throwIfNotFound: true);
        m_RightVRcontroller_DevicePoseIsTracked = m_RightVRcontroller.FindAction("DevicePoseIsTracked", throwIfNotFound: true);
        m_RightVRcontroller_IsTracked = m_RightVRcontroller.FindAction("IsTracked", throwIfNotFound: true);
        m_RightVRcontroller_Menu = m_RightVRcontroller.FindAction("Menu", throwIfNotFound: true);
        m_RightVRcontroller_PointerIsTracked = m_RightVRcontroller.FindAction("PointerIsTracked", throwIfNotFound: true);
        m_RightVRcontroller_Select = m_RightVRcontroller.FindAction("Select", throwIfNotFound: true);
        m_RightVRcontroller_TrackPadClicked = m_RightVRcontroller.FindAction("TrackPadClicked", throwIfNotFound: true);
        m_RightVRcontroller_TrackPadTouched = m_RightVRcontroller.FindAction("TrackPadTouched", throwIfNotFound: true);
        m_RightVRcontroller_TriggerPressed = m_RightVRcontroller.FindAction("TriggerPressed", throwIfNotFound: true);
        m_RightVRcontroller_Position = m_RightVRcontroller.FindAction("Position", throwIfNotFound: true);
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

    // LeftVRcontroller
    private readonly InputActionMap m_LeftVRcontroller;
    private ILeftVRcontrollerActions m_LeftVRcontrollerActionsCallbackInterface;
    private readonly InputAction m_LeftVRcontroller_Squeeze;
    private readonly InputAction m_LeftVRcontroller_Grip;
    private readonly InputAction m_LeftVRcontroller_TrackPadClick;
    private readonly InputAction m_LeftVRcontroller_TrackPadTouched;
    private readonly InputAction m_LeftVRcontroller_TriggerPressed;
    private readonly InputAction m_LeftVRcontroller_IsTracked;
    private readonly InputAction m_LeftVRcontroller_Menu;
    private readonly InputAction m_LeftVRcontroller_PointerIsTracked;
    private readonly InputAction m_LeftVRcontroller_DevicePoseIsTracked;
    private readonly InputAction m_LeftVRcontroller_Position;
    public struct LeftVRcontrollerActions
    {
        private @PlayerInputActions m_Wrapper;
        public LeftVRcontrollerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Squeeze => m_Wrapper.m_LeftVRcontroller_Squeeze;
        public InputAction @Grip => m_Wrapper.m_LeftVRcontroller_Grip;
        public InputAction @TrackPadClick => m_Wrapper.m_LeftVRcontroller_TrackPadClick;
        public InputAction @TrackPadTouched => m_Wrapper.m_LeftVRcontroller_TrackPadTouched;
        public InputAction @TriggerPressed => m_Wrapper.m_LeftVRcontroller_TriggerPressed;
        public InputAction @IsTracked => m_Wrapper.m_LeftVRcontroller_IsTracked;
        public InputAction @Menu => m_Wrapper.m_LeftVRcontroller_Menu;
        public InputAction @PointerIsTracked => m_Wrapper.m_LeftVRcontroller_PointerIsTracked;
        public InputAction @DevicePoseIsTracked => m_Wrapper.m_LeftVRcontroller_DevicePoseIsTracked;
        public InputAction @Position => m_Wrapper.m_LeftVRcontroller_Position;
        public InputActionMap Get() { return m_Wrapper.m_LeftVRcontroller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftVRcontrollerActions set) { return set.Get(); }
        public void SetCallbacks(ILeftVRcontrollerActions instance)
        {
            if (m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface != null)
            {
                @Squeeze.started -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnSqueeze;
                @Squeeze.performed -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnSqueeze;
                @Squeeze.canceled -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnSqueeze;
                @Grip.started -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnGrip;
                @Grip.performed -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnGrip;
                @Grip.canceled -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnGrip;
                @TrackPadClick.started -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnTrackPadClick;
                @TrackPadClick.performed -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnTrackPadClick;
                @TrackPadClick.canceled -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnTrackPadClick;
                @TrackPadTouched.started -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnTrackPadTouched;
                @TrackPadTouched.performed -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnTrackPadTouched;
                @TrackPadTouched.canceled -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnTrackPadTouched;
                @TriggerPressed.started -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnTriggerPressed;
                @TriggerPressed.performed -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnTriggerPressed;
                @TriggerPressed.canceled -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnTriggerPressed;
                @IsTracked.started -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnIsTracked;
                @IsTracked.performed -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnIsTracked;
                @IsTracked.canceled -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnIsTracked;
                @Menu.started -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnMenu;
                @PointerIsTracked.started -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnPointerIsTracked;
                @PointerIsTracked.performed -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnPointerIsTracked;
                @PointerIsTracked.canceled -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnPointerIsTracked;
                @DevicePoseIsTracked.started -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnDevicePoseIsTracked;
                @DevicePoseIsTracked.performed -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnDevicePoseIsTracked;
                @DevicePoseIsTracked.canceled -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnDevicePoseIsTracked;
                @Position.started -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface.OnPosition;
            }
            m_Wrapper.m_LeftVRcontrollerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Squeeze.started += instance.OnSqueeze;
                @Squeeze.performed += instance.OnSqueeze;
                @Squeeze.canceled += instance.OnSqueeze;
                @Grip.started += instance.OnGrip;
                @Grip.performed += instance.OnGrip;
                @Grip.canceled += instance.OnGrip;
                @TrackPadClick.started += instance.OnTrackPadClick;
                @TrackPadClick.performed += instance.OnTrackPadClick;
                @TrackPadClick.canceled += instance.OnTrackPadClick;
                @TrackPadTouched.started += instance.OnTrackPadTouched;
                @TrackPadTouched.performed += instance.OnTrackPadTouched;
                @TrackPadTouched.canceled += instance.OnTrackPadTouched;
                @TriggerPressed.started += instance.OnTriggerPressed;
                @TriggerPressed.performed += instance.OnTriggerPressed;
                @TriggerPressed.canceled += instance.OnTriggerPressed;
                @IsTracked.started += instance.OnIsTracked;
                @IsTracked.performed += instance.OnIsTracked;
                @IsTracked.canceled += instance.OnIsTracked;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @PointerIsTracked.started += instance.OnPointerIsTracked;
                @PointerIsTracked.performed += instance.OnPointerIsTracked;
                @PointerIsTracked.canceled += instance.OnPointerIsTracked;
                @DevicePoseIsTracked.started += instance.OnDevicePoseIsTracked;
                @DevicePoseIsTracked.performed += instance.OnDevicePoseIsTracked;
                @DevicePoseIsTracked.canceled += instance.OnDevicePoseIsTracked;
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
            }
        }
    }
    public LeftVRcontrollerActions @LeftVRcontroller => new LeftVRcontrollerActions(this);

    // RightVRcontroller
    private readonly InputActionMap m_RightVRcontroller;
    private IRightVRcontrollerActions m_RightVRcontrollerActionsCallbackInterface;
    private readonly InputAction m_RightVRcontroller_GripPressed;
    private readonly InputAction m_RightVRcontroller_DevicePoseIsTracked;
    private readonly InputAction m_RightVRcontroller_IsTracked;
    private readonly InputAction m_RightVRcontroller_Menu;
    private readonly InputAction m_RightVRcontroller_PointerIsTracked;
    private readonly InputAction m_RightVRcontroller_Select;
    private readonly InputAction m_RightVRcontroller_TrackPadClicked;
    private readonly InputAction m_RightVRcontroller_TrackPadTouched;
    private readonly InputAction m_RightVRcontroller_TriggerPressed;
    private readonly InputAction m_RightVRcontroller_Position;
    public struct RightVRcontrollerActions
    {
        private @PlayerInputActions m_Wrapper;
        public RightVRcontrollerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @GripPressed => m_Wrapper.m_RightVRcontroller_GripPressed;
        public InputAction @DevicePoseIsTracked => m_Wrapper.m_RightVRcontroller_DevicePoseIsTracked;
        public InputAction @IsTracked => m_Wrapper.m_RightVRcontroller_IsTracked;
        public InputAction @Menu => m_Wrapper.m_RightVRcontroller_Menu;
        public InputAction @PointerIsTracked => m_Wrapper.m_RightVRcontroller_PointerIsTracked;
        public InputAction @Select => m_Wrapper.m_RightVRcontroller_Select;
        public InputAction @TrackPadClicked => m_Wrapper.m_RightVRcontroller_TrackPadClicked;
        public InputAction @TrackPadTouched => m_Wrapper.m_RightVRcontroller_TrackPadTouched;
        public InputAction @TriggerPressed => m_Wrapper.m_RightVRcontroller_TriggerPressed;
        public InputAction @Position => m_Wrapper.m_RightVRcontroller_Position;
        public InputActionMap Get() { return m_Wrapper.m_RightVRcontroller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightVRcontrollerActions set) { return set.Get(); }
        public void SetCallbacks(IRightVRcontrollerActions instance)
        {
            if (m_Wrapper.m_RightVRcontrollerActionsCallbackInterface != null)
            {
                @GripPressed.started -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnGripPressed;
                @GripPressed.performed -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnGripPressed;
                @GripPressed.canceled -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnGripPressed;
                @DevicePoseIsTracked.started -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnDevicePoseIsTracked;
                @DevicePoseIsTracked.performed -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnDevicePoseIsTracked;
                @DevicePoseIsTracked.canceled -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnDevicePoseIsTracked;
                @IsTracked.started -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnIsTracked;
                @IsTracked.performed -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnIsTracked;
                @IsTracked.canceled -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnIsTracked;
                @Menu.started -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnMenu;
                @PointerIsTracked.started -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnPointerIsTracked;
                @PointerIsTracked.performed -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnPointerIsTracked;
                @PointerIsTracked.canceled -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnPointerIsTracked;
                @Select.started -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnSelect;
                @TrackPadClicked.started -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnTrackPadClicked;
                @TrackPadClicked.performed -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnTrackPadClicked;
                @TrackPadClicked.canceled -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnTrackPadClicked;
                @TrackPadTouched.started -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnTrackPadTouched;
                @TrackPadTouched.performed -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnTrackPadTouched;
                @TrackPadTouched.canceled -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnTrackPadTouched;
                @TriggerPressed.started -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnTriggerPressed;
                @TriggerPressed.performed -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnTriggerPressed;
                @TriggerPressed.canceled -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnTriggerPressed;
                @Position.started -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_RightVRcontrollerActionsCallbackInterface.OnPosition;
            }
            m_Wrapper.m_RightVRcontrollerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GripPressed.started += instance.OnGripPressed;
                @GripPressed.performed += instance.OnGripPressed;
                @GripPressed.canceled += instance.OnGripPressed;
                @DevicePoseIsTracked.started += instance.OnDevicePoseIsTracked;
                @DevicePoseIsTracked.performed += instance.OnDevicePoseIsTracked;
                @DevicePoseIsTracked.canceled += instance.OnDevicePoseIsTracked;
                @IsTracked.started += instance.OnIsTracked;
                @IsTracked.performed += instance.OnIsTracked;
                @IsTracked.canceled += instance.OnIsTracked;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @PointerIsTracked.started += instance.OnPointerIsTracked;
                @PointerIsTracked.performed += instance.OnPointerIsTracked;
                @PointerIsTracked.canceled += instance.OnPointerIsTracked;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @TrackPadClicked.started += instance.OnTrackPadClicked;
                @TrackPadClicked.performed += instance.OnTrackPadClicked;
                @TrackPadClicked.canceled += instance.OnTrackPadClicked;
                @TrackPadTouched.started += instance.OnTrackPadTouched;
                @TrackPadTouched.performed += instance.OnTrackPadTouched;
                @TrackPadTouched.canceled += instance.OnTrackPadTouched;
                @TriggerPressed.started += instance.OnTriggerPressed;
                @TriggerPressed.performed += instance.OnTriggerPressed;
                @TriggerPressed.canceled += instance.OnTriggerPressed;
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
            }
        }
    }
    public RightVRcontrollerActions @RightVRcontroller => new RightVRcontrollerActions(this);
    public interface ILeftVRcontrollerActions
    {
        void OnSqueeze(InputAction.CallbackContext context);
        void OnGrip(InputAction.CallbackContext context);
        void OnTrackPadClick(InputAction.CallbackContext context);
        void OnTrackPadTouched(InputAction.CallbackContext context);
        void OnTriggerPressed(InputAction.CallbackContext context);
        void OnIsTracked(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnPointerIsTracked(InputAction.CallbackContext context);
        void OnDevicePoseIsTracked(InputAction.CallbackContext context);
        void OnPosition(InputAction.CallbackContext context);
    }
    public interface IRightVRcontrollerActions
    {
        void OnGripPressed(InputAction.CallbackContext context);
        void OnDevicePoseIsTracked(InputAction.CallbackContext context);
        void OnIsTracked(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnPointerIsTracked(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnTrackPadClicked(InputAction.CallbackContext context);
        void OnTrackPadTouched(InputAction.CallbackContext context);
        void OnTriggerPressed(InputAction.CallbackContext context);
        void OnPosition(InputAction.CallbackContext context);
    }
}
