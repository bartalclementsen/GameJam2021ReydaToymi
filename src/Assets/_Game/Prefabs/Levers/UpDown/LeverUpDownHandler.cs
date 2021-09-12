using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverUpDownHandler : MonoBehaviour, IMouseClickable
{
    [SerializeField]
    private float minMax = 0.2f;

    private float min = 0;

    private float max = 0;

    private float current = 0;

    private float speed = 1.0f;

    private bool isDragging = false;

    private Core.Mediators.IMessenger messenger;

    private void Start()
    {
        messenger = Game.Container.Resolve<Core.Mediators.IMessenger>();
        current = transform.localPosition.y;
        min = current - minMax;
        max = current + minMax;
    }

    private void Update()
    {
        if (isDragging)
        {
            float increment = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
            current = Mathf.Min(max, Mathf.Max(min, transform.localPosition.y + increment));
            transform.localPosition = new Vector3(transform.localPosition.x, current, transform.localPosition.z);
        }

        var diff = current - min;
        var fraction = (diff / (minMax * 2));
        var movementValue = fraction * 2 - 1;

        if (movementValue > 0.1 || movementValue < -0.1)
        {
            messenger.Publish(new AccelerateYMessage(movementValue));
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
