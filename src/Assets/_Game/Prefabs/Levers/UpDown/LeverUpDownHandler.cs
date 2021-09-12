using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverUpDownHandler : MonoBehaviour, IMouseClickable
{
    public TestViveControllerScript viveControllerScript;

    [SerializeField]
    private float minMax = 0.2f;

    [SerializeField]
    private AudioClip[] positiveAudioClip;
    
    [SerializeField]
    private AudioClip[] negativeAudioClip;

    [SerializeField]
    private AudioSource audioSource;

    private float min = 0;

    private float max = 0;

    private float current = 0;

    private float speed = 1.0f;

    private bool isDragging = false;

    private Core.Mediators.IMessenger messenger;
    
    private Grabber grabber = Grabber.NONE;

    private void Start()
    {
        messenger = Game.Container.Resolve<Core.Mediators.IMessenger>();
        current = transform.localPosition.y;
        min = current - minMax;
        max = current + minMax;

        audioSource.loop = true;
    }

    private void Update()
    {
        if (isDragging) {
            float velocity =
                grabber == Grabber.MOUSE
                ? Input.GetAxis("Mouse Y")
                : grabber == Grabber.RIGHT_VIVE
                    ? viveControllerScript.getRightHandVelocity().y
                    : viveControllerScript.getLeftHandVelocity().y;
            float speedMultiplier = grabber == Grabber.RIGHT_VIVE || grabber == Grabber.LEFT_VIVE ? 2 : 1;

            float increment = velocity * speed * speedMultiplier * Time.deltaTime;
            current = Mathf.Min(max, Mathf.Max(min, transform.localPosition.y + increment));
            transform.localPosition = new Vector3(transform.localPosition.x, current, transform.localPosition.z);
        }

        var diff = current - min;
        var fraction = (diff / (minMax * 2));
        var movementValue = fraction * 2 - 1;

        if (isDragging)
        {
            PlaySound(movementValue);
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
        }

        if (movementValue > 0.1 || movementValue < -0.1)
        {
            messenger.Publish(new AccelerateYMessage(movementValue));
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

    private void PlaySound(float volume)
    {
        if (audioSource == null)
            return;

        if (positiveAudioClip == null)
            return;

        int index = Random.Range(0, positiveAudioClip.Length - 2);
        AudioClip collisionAudioClip = negativeAudioClip[index];
        if(volume < 0)
        {
            collisionAudioClip = positiveAudioClip[index];
        }
        
        audioSource.volume = Mathf.Abs(volume);

        if (audioSource.isPlaying == false || audioSource.clip != collisionAudioClip)
        {
            audioSource.clip = collisionAudioClip;
            audioSource.Play();
        }
    }
}
