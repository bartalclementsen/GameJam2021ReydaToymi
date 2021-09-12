using Core.Mediators;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    private IMessenger message;
    private ISubscriptionToken playerCollidedMessageToken;

    private float shake = 0;
    private float shakeAmount = 0.01f;
    private float decreaseFactor = 1;

    public float mouseSensitivity = 400.0f;
    public float clampAngle = 80.0f;

    private float rotY = 0.0f; // rotation around the up/y axis
    private float rotX = 0.0f; // rotation around the right/x axis

    private Camera camera;

    void Start()
    {
        message = Game.Container.Resolve<IMessenger>();
        playerCollidedMessageToken = message.Subscribe<PlayerCollidedMessage>(HandleMessage);

        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;

        camera = GetComponent<Camera>();
    }

    private bool isMouseCaptured = false;
    private IMouseClickable mouseClickable;

    private void Update()
    {
        if(isMouseCaptured == false)
        {

            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = -Input.GetAxis("Mouse Y");

            rotY += mouseX * mouseSensitivity * Time.deltaTime;
            rotX += mouseY * mouseSensitivity * Time.deltaTime;

            rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

            Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
            transform.rotation = localRotation;
        }

        var ray = camera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction, Color.red, 0.1f);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out RaycastHit hit)) {
                Debug.Log(hit, hit.collider.gameObject);
                IMouseClickable v = hit.collider.GetComponentInParent<IMouseClickable>();
                Debug.Log(v);
                if (v != null)
                {
                    mouseClickable = v;
                    mouseClickable.MouseDown();
                    isMouseCaptured = true;
                }
            }
        } else if (Input.GetMouseButtonUp(0))
        {
            if(mouseClickable != null)
            {
                mouseClickable.MouseUp();
                mouseClickable = null;
            }

            isMouseCaptured = false;
        }
    }

    private void HandleMessage(PlayerCollidedMessage obj)
    {
        return; // TODO: FIX CAMERA SHAKE
        StartCoroutine(Shake(0.7f, 0.005f));
    }

    IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 OriginalPos = transform.position;
        float elapsed = 0.0f;
        while (elapsed < duration)
        {

            float x = UnityEngine.Random.Range(-1f, 1f) * magnitude;
            float y = UnityEngine.Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, OriginalPos.z);

            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = OriginalPos;

    }
}
