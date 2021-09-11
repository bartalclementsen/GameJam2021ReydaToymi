using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLeftRightHandler : MonoBehaviour, IMouseClickable
{
    [SerializeField]
    private GameObject handle;

    private float min = -60;

    private float max = 60;

    private float current = 0;

    private float speed = 50;

    private bool isDragging = false;

    private Core.Mediators.IMessenger messenger;

    private void Start()
    {
        messenger = Game.Container.Resolve<Core.Mediators.IMessenger>();
    }

    private void Update()
    {
        if (isDragging)
        {
            float increment = -Input.GetAxis("Mouse X") * speed * Time.deltaTime;
            current = Mathf.Max(min, Mathf.Min(max, current + increment));
            handle.transform.localRotation = Quaternion.Euler(0, current, 0);
        }

        if (current > 0.1 || current < -0.1)
        {
            float movementValue = current / 60.0f;
            messenger.Publish(new AccelerateXMessage(-movementValue));
        }
    }

    public void MouseDown()
    {
        isDragging = true;
    }

    public void MouseUp()
    {
        isDragging = false;
    }
}

