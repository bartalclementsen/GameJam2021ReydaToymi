using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverUpDownHandler : MonoBehaviour, IMouseClickable
{
    [SerializeField]
    private float minMax = 60;

    private float current = 0;

    private float speed = 0.1f;

    private bool isDragging = false;

    private Core.Mediators.IMessenger messenger;

    private void Start()
    {
        messenger = Game.Container.Resolve<Core.Mediators.IMessenger>();
        current = transform.position.y;
        min = current - minMax;
        max = current + minMax;
    }

    private void Update()
    {
        if (isDragging)
        {
            float increment = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
            current = Mathf.Min(max, Mathf.Max(min, transform.position.y + increment));
            transform.position = new Vector3(transform.position.x, current, transform.position.z);
        }

        if (current > 0.1 || current < -0.1)
        {
            float movementValue = current / 60.0f;
            messenger.Publish(new AccelerateZMessage(movementValue));
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
