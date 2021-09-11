using Core.Mediators;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float acceleration = 50;

    [SerializeField]
    private float maxSpeed = 1;

    [SerializeField]
    private AudioSource engineAudioSource;

    [SerializeField]
    private AudioSource musicAudioSource;

    [SerializeField]
    private AudioSource collisionAudioSource;

    [SerializeField]
    private AudioClip[] collisionSounds;

    private IMessenger message;
    private Core.Loggers.ILogger logger;
    private Rigidbody rigidbody;

    private float minEnginVolumen = 0.1f;

    private Core.Mediators.ISubscriptionToken accelerateXMessageToken;
    private Core.Mediators.ISubscriptionToken accelerateYMessage;
    private Core.Mediators.ISubscriptionToken accelerateZMessage;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        rigidbody = GetComponent<Rigidbody>();

        logger = Game.Container.Resolve<Core.Loggers.ILoggerFactory>().Create(this);

        message = Game.Container.Resolve<IMessenger>();
        accelerateXMessageToken = message.Subscribe<AccelerateXMessage>(HandleMessage);
        accelerateYMessage = message.Subscribe<AccelerateYMessage>(HandleMessage);
        accelerateZMessage = message.Subscribe<AccelerateZMessage>(HandleMessage);
    }

    private void OnDestroy()
    {
        accelerateXMessageToken.Dispose();
        accelerateYMessage.Dispose();
        accelerateZMessage.Dispose();
    }

    private void FixedUpdate()
    {
        var velocity = rigidbody.velocity;
        var sqrMagnitude = velocity.sqrMagnitude;
        var newVelocity = velocity.normalized * maxSpeed;

        if (sqrMagnitude > newVelocity.sqrMagnitude)
        {
            rigidbody.velocity = newVelocity;
        }

        float velocityFactor = Mathf.Max(0, Mathf.Min(1, rigidbody.velocity.sqrMagnitude / newVelocity.sqrMagnitude));
        float engineVolume = (1 - minEnginVolumen) * velocityFactor;
        float newVolume = minEnginVolumen + engineVolume;

        engineAudioSource.volume = Mathf.Max(minEnginVolumen, Mathf.Min(1, newVolume));
        if (engineAudioSource.volume == float.NaN)
        {
            engineAudioSource.volume =  minEnginVolumen;
        }
    }

    private void HandleMessage(AccelerateXMessage message)
    {
        float forceValue = Mathf.Abs(message.Value) * acceleration * Time.deltaTime;

        var forceVector = new Vector3(forceValue, 0, 0);
        if (message.Value < 0)
            forceVector = forceVector * -1;

        rigidbody.AddForce(forceVector);
    }

    private void HandleMessage(AccelerateYMessage message)
    {
        float forceValue = Mathf.Abs(message.Value) * acceleration * Time.deltaTime;

        var forceVector = new Vector3(0, forceValue, 0);
        if (message.Value < 0)
            forceVector = forceVector * -1;

        rigidbody.AddForce(forceVector);
    }

    private void HandleMessage(AccelerateZMessage message)
    {
        float forceValue = Mathf.Abs(message.Value) * acceleration * Time.deltaTime;

        var forceVector = new Vector3(0, 0, forceValue);
        if (message.Value < 0)
            forceVector = forceVector * -1;

        rigidbody.AddForce(forceVector);
    }

    void OnCollisionEnter(Collision collision)
    {
        message.Publish(new PlayerCollidedMessage(collision));

        var firstContact = collision.contacts[0];
        
        PlayCollisionSound(firstContact.point);
    }

    private void PlayCollisionSound(Vector3 position)
    {
        int index = Random.Range(0, collisionSounds.Length - 1);
        AudioClip collisionAudioClip = collisionSounds[index];

        collisionAudioSource.transform.position = position;
        collisionAudioSource.clip = collisionAudioClip;
        collisionAudioSource.Play();
    }
}
