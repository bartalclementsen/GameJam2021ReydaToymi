using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestViveControllerScript : MonoBehaviour {

    Vector3 RightHandPosition, LeftHandPosition;
    Quaternion RightHandRotation, LeftHandRotation;

    public GameObject LeftController, RightController;
    public GameObject handsOrigin;

    private void Start() {
        PlayerInputActions playerInputActions = new PlayerInputActions();
        playerInputActions.LeftVRcontroller.Position.performed += OnLeftPositionPerformed;
        playerInputActions.RightVRcontroller.Position.performed += OnRightPositionPerformed;
    }

    private void Update() {
        //var inputDevices = new List<UnityEngine.XR.InputDevice>();
        //UnityEngine.XR.InputDevices.GetDevices(inputDevices);
        //foreach (var device in inputDevices) {
        //    Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, device.role.ToString()));

        //    Debug.Log(UnityEngine.XR.InputTracking.GetLocalPosition(UnityEngine.XR.XRNode.RightHand));
        //    // TElls me to use the below code, but it also won't accept it
        //    //Debug.Log(device.TryGetFeatureValue(CommonUsages.devicePosition, out bool pos));
        //}

        RightHandPosition = UnityEngine.XR.InputTracking.GetLocalPosition(UnityEngine.XR.XRNode.RightHand);
        RightController.transform.position = handsOrigin.transform.position + RightHandPosition;
        RightHandRotation = UnityEngine.XR.InputTracking.GetLocalRotation(UnityEngine.XR.XRNode.RightHand);
        RightController.transform.rotation = RightHandRotation;
        RightController.transform.rotation *= Quaternion.Euler(0, 90, 0);

        LeftHandPosition = UnityEngine.XR.InputTracking.GetLocalPosition(UnityEngine.XR.XRNode.LeftHand);
        LeftController.transform.position = handsOrigin.transform.position + LeftHandPosition;
        LeftHandRotation = UnityEngine.XR.InputTracking.GetLocalRotation(UnityEngine.XR.XRNode.LeftHand);
        LeftController.transform.rotation = LeftHandRotation;
        LeftController.transform.rotation *= Quaternion.Euler(0, 90, 0);
    }

    private void OnLeftPositionPerformed(InputAction.CallbackContext obj) {
        Debug.Log(obj);
    }

    private void OnRightPositionPerformed(InputAction.CallbackContext obj) {
        Debug.Log(obj);
    }

    public void Test() {
        Debug.Log("here");
    }

    public void TriggerPressed() {
        Debug.Log("TriggerPressed");
    }

    public void GripPressed() {
        Debug.Log("GripPressed");
    }

    public void IsTracked() {
        Debug.Log("IsTracked");
    }

    public void Select() {
        Debug.Log("Select");
    }

    public void Menu() {
        Debug.Log("Menu");
    }

    public void Position(Vector3 position) {
        Debug.Log("Position");
        Debug.Log(position);
    }

}
