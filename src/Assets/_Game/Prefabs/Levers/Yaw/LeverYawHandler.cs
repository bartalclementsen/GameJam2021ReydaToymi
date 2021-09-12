using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverYawHandler : MonoBehaviour, IMouseClickable
{
    [SerializeField]
    private float minMax = 0.2f;

    [SerializeField]
    private GameObject handle;

    [SerializeField]
    private AudioClip audioClip;

    [SerializeField]
    private AudioSource audioSource;

    private float min = -90;

    private float max = 90;

    private float current = 0;

    private float speed = 100.0f;

    private bool isDragging = false;

    private Core.Mediators.IMessenger messenger;

    private Grabber grabber;

    private void Start()
    {
        messenger = Game.Container.Resolve<Core.Mediators.IMessenger>();

        if(audioSource != null)
        {
            audioSource.loop = true;
            audioSource.clip = audioClip;
        }
    }

    private void Update()
    {
        if (isDragging)
        {
            float increment = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
            current = Mathf.Max(min, Mathf.Min(max, current + increment));
            handle.transform.localRotation = Quaternion.Euler(0, 0, current);
        }

        if (isDragging)
        {
            PlaySound();
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
        }

        if (current > 0.1 || current < -0.1)
        {
            float movementValue = current / 90.0f;
            messenger.Publish(new AccelerateYawMessage(movementValue));
        }
    }

    public void MouseDown()
    {
        if (grabber == Grabber.NONE) isDragging = true;
    }

    public void MouseUp()
    {
        isDragging = false;
        grabber = Grabber.NONE;
    }

    public void SetGrabber(Grabber g) {
        grabber = g;
    }

    public bool GetIsDragging() => isDragging;

    private void PlaySound()
    {
        if (audioSource == null)
            return;

        if (audioSource.isPlaying == false)
        {
            audioSource.Play();
        }
    }
}

