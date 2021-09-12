using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestViveControllerScript : MonoBehaviour {

    static Vector3 RightHandPosition, RightHandVelocity, LeftHandPosition, LeftHandVelocity;
    static Quaternion RightHandRotation, LeftHandRotation;

    public GameObject LeftController, RightController;
    public CapsuleCollider LeftCollider, RightCollider;
    public GameObject handsOrigin;

    private void Start() {
        PlayerInputActions playerInputActions = new PlayerInputActions();
        playerInputActions.LeftVRcontroller.Position.performed += OnLeftPositionPerformed;
        playerInputActions.RightVRcontroller.Position.performed += OnRightPositionPerformed;
    }

    private void Update() {
        var device = UnityEngine.XR.InputDevices.GetDeviceAtXRNode(UnityEngine.XR.XRNode.RightHand);
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceVelocity, out var rightVelocity);
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.devicePosition, out var rightPosition);
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceRotation, out var rightRotation);
        rightRotation *= Quaternion.Euler(0, 90, 0);

        RightHandPosition = rightPosition;
        Vector3 rightX = handsOrigin.transform.forward * rightPosition.z;
        Vector3 rightY = handsOrigin.transform.up * rightPosition.y;
        Vector3 rightZ = handsOrigin.transform.right * rightPosition.x;
        RightController.transform.position = (rightX + rightY + rightZ) + handsOrigin.transform.position;

        RightHandRotation = rightRotation;
        //RightController.transform.rotation = RightHandRotation;
        RightHandVelocity = rightVelocity;

        device = UnityEngine.XR.InputDevices.GetDeviceAtXRNode(UnityEngine.XR.XRNode.LeftHand);
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceVelocity, out var LeftVelocity);
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.devicePosition, out var leftPosition);
        device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceRotation, out var leftRotation);
        leftRotation *= Quaternion.Euler(0, 90, 0);

        LeftHandPosition = leftPosition;
        Vector3 leftX = handsOrigin.transform.forward * leftPosition.z;
        Vector3 leftY = handsOrigin.transform.up * leftPosition.y;
        Vector3 leftZ = handsOrigin.transform.right * leftPosition.x;

        LeftController.transform.position = (leftX + leftY + leftZ) + handsOrigin.transform.position;
        
        LeftController.transform.RotateAround(handsOrigin.transform.position, Vector3.up, handsOrigin.transform.rotation.x);
        LeftController.transform.RotateAround(handsOrigin.transform.position, Vector3.forward, handsOrigin.transform.rotation.z);
        LeftController.transform.RotateAround(handsOrigin.transform.position, Vector3.right, handsOrigin.transform.rotation.y);
        LeftHandRotation = leftRotation;
        //LeftController.transform.rotation = LeftHandRotation;
        LeftHandVelocity = LeftVelocity;
    }

    public Vector3 getRightHandVelocity() => RightHandVelocity;
    public Vector3 getLeftHandVelocity() =>  LeftHandVelocity;

    public void LeftTriggerPressed() {
        GetOverlaps(LeftCollider, Grabber.LEFT_VIVE);
    }

    public void RightTriggerPressed() {
        GetOverlaps(RightCollider, Grabber.RIGHT_VIVE);
    }

    private void GetOverlaps(CapsuleCollider collider, Grabber grabber) {
        var col = collider;
        var direction = new Vector3 { [col.direction] = 1 };
        var offset = col.height / 2 - col.radius;
        var localPoint0 = col.center - direction * offset;
        var localPoint1 = col.center + direction * offset;
        var point0 = col.transform.position + localPoint0;
        var point1 = col.transform.position + localPoint1;
        var middle = (point0 + point1) / 2;
        var radius = col.radius; // gets really big for some reason
        radius = 0.1f;
        var colliders = Physics.OverlapSphere(middle, radius);
        Debug.DrawLine(point0, point1, Color.red, 10);
        Debug.DrawLine(middle + Vector3.forward * radius, middle + Vector3.back * radius, Color.red, 10);
        Debug.DrawLine(middle + Vector3.left * radius, middle + Vector3.right * radius, Color.red, 10);
        colliders.ToList().ForEach(
            a => {
                var script = a.GetComponentInParent<IMouseClickable>();
                if (script != null) {
                    Debug.Log(script);
                    if (script.GetIsDragging()) {
                        script.MouseUp();
                    } else {
                        script.MouseDown();
                        script.SetGrabber(grabber);
                    }
                }
            }
        );

    }

    #region unused events
    private void OnLeftPositionPerformed(InputAction.CallbackContext obj) {
        Debug.Log(obj);
    }

    private void OnRightPositionPerformed(InputAction.CallbackContext obj) {
        Debug.Log(obj);
    }

    public void Test() {
        Debug.Log("here");
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
