using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestViveControllerScript : MonoBehaviour {

    static Vector3 RightHandPosition, RightHandVelocity, LeftHandPosition, LeftHandVelocity;
    static Quaternion RightHandRotation, LeftHandRotation;

    public GameObject LeftController, RightController;
    public GameObject handsOrigin;

    private void Start() {
        PlayerInputActions playerInputActions = new PlayerInputActions();
        playerInputActions.LeftVRcontroller.Position.performed += OnLeftPositionPerformed;
        playerInputActions.RightVRcontroller.Position.performed += OnRightPositionPerformed;
    }

    private void Update() {
        var device = UnityEngine.XR.InputDevices.GetDeviceAtXRNode(UnityEngine.XR.XRNode.RightHand);
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceAngularVelocity, out var rightVelocity);
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.devicePosition, out var rightPosition);
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceRotation, out var rightRotation);
        rightRotation *= Quaternion.Euler(0, 90, 0);

        RightHandPosition = rightPosition;
        RightController.transform.position = RightHandPosition + handsOrigin.transform.position;
        RightHandRotation = rightRotation;
        RightController.transform.rotation = RightHandRotation;
        RightHandVelocity = rightVelocity;

        device = UnityEngine.XR.InputDevices.GetDeviceAtXRNode(UnityEngine.XR.XRNode.LeftHand);
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceAngularVelocity, out var LeftVelocity);
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.devicePosition, out var leftPosition);
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceRotation, out var leftRotation);
        leftRotation *= Quaternion.Euler(0, 90, 0);

        LeftHandPosition = leftPosition;
        LeftController.transform.position = LeftHandPosition + handsOrigin.transform.position;
        LeftHandRotation = leftRotation;
        LeftController.transform.rotation = LeftHandRotation;
        LeftHandVelocity = LeftVelocity;
    }

    public Vector3 getRightHandVelocity() {
        return RightHandVelocity;
    }
    public Vector3 getLeftHandVelocity() {
        return RightHandVelocity;
    }

    #region events
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
    #endregion
}
