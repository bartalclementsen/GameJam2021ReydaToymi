using Core.Mediators;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private float startTime = 0f;

    private int currentCollisions = 0;
    private int maxCollisions = 3;

    [SerializeField]
    private float acceleration = 50;

    [SerializeField]
    private float rollAcceleration = 5;

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

    [SerializeField]
    private Text timeText;

    [SerializeField]
    private Text crashesText;

    private IMessenger message;
    private Core.Loggers.ILogger logger;
    private Rigidbody rigidbody;

    private float minEnginVolumen = 0.1f;
    private float lastCollisionTime = 0f;
    private float minTimeBethweenCollisions = 1f;

    private Core.Mediators.ISubscriptionToken accelerateXMessageToken;
    private Core.Mediators.ISubscriptionToken accelerateYMessage;
    private Core.Mediators.ISubscriptionToken accelerateZMessage;

    private Core.Mediators.ISubscriptionToken accelerateYawMessage;
    private Core.Mediators.ISubscriptionToken acceleratePitchMessage;
    private Core.Mediators.ISubscriptionToken accelerateRollMessage;

    private System.Random random = new System.Random();

    void Start()
    {

        startTime = Time.time;

        Cursor.lockState = CursorLockMode.Locked;

        rigidbody = GetComponent<Rigidbody>();

        logger = Game.Container.Resolve<Core.Loggers.ILoggerFactory>().Create(this);

        message = Game.Container.Resolve<IMessenger>();
        accelerateXMessageToken = message.Subscribe<AccelerateXMessage>(HandleMessage);
        accelerateYMessage = message.Subscribe<AccelerateYMessage>(HandleMessage);
        accelerateZMessage = message.Subscribe<AccelerateZMessage>(HandleMessage);
        accelerateYawMessage = message.Subscribe<AccelerateYawMessage>(HandleMessage);
        acceleratePitchMessage = message.Subscribe<AcceleratePitchMessage>(HandleMessage);
        accelerateRollMessage = message.Subscribe<AccelerateRollMessage>(HandleMessage);
    }

    private void Update()
    {
        var secondsSinceStart = (int)(Time.time - startTime);

        var seconds = secondsSinceStart % 60;
        var minutes = (secondsSinceStart - seconds) / 60;
        timeText.text = $"{minutes:##00}:{seconds:00}";

        crashesText.text = $"Crashes {currentCollisions}/{maxCollisions}";
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

        var angularVelocity = rigidbody.angularVelocity;
        var angularSqrMagnitude = angularVelocity.sqrMagnitude;
        var angularNewVelocity = angularVelocity.normalized * maxSpeed;

        if (angularSqrMagnitude > angularNewVelocity.sqrMagnitude)
        {
            rigidbody.angularVelocity = angularNewVelocity;
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
        float forceValue = message.Value * acceleration * Time.deltaTime;
        rigidbody.AddForce(transform.right * forceValue);
    }

    private void HandleMessage(AccelerateYMessage message)
    {
        float forceValue = message.Value * acceleration * Time.deltaTime;
        
        rigidbody.AddForce(Vector3.up * forceValue);
    }

    private void HandleMessage(AccelerateZMessage message)
    {
        float forceValue = message.Value * acceleration * Time.deltaTime;
        rigidbody.AddForce(transform.forward * forceValue);
    }



    private void HandleMessage(AccelerateYawMessage message)
    {
        float forceValue = message.Value * rollAcceleration * Time.deltaTime;

        rigidbody.AddTorque(this.transform.up * forceValue);
    }



    private void HandleMessage(AcceleratePitchMessage message)
    {
        float forceValue = message.Value * rollAcceleration * Time.deltaTime;

        rigidbody.AddTorque(this.transform.right * forceValue);
    }


    private void HandleMessage(AccelerateRollMessage message)
    {
        float forceValue = message.Value * rollAcceleration * Time.deltaTime;

        rigidbody.AddTorque(this.transform.forward * forceValue);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(Time.time - lastCollisionTime <= minTimeBethweenCollisions)
        {
            logger.Log("CollisionEntered (ignored because of repetition)");
            return; //Ignore this collision
        }

        logger.Log("CollisionEntered");
        lastCollisionTime = Time.time;
        message.Publish(new PlayerCollidedMessage(collision));

        currentCollisions++;

        var firstContact = collision.contacts[0];
        PlayCollisionSound(firstContact.point);

        if(currentCollisions >= maxCollisions)
        {
            message.Publish(new PlayerDeathMessage(PlayerDeathType.Collisions));
        }
    }

    private void PlayCollisionSound(Vector3 position)
    {
        int index = random.Next(0, collisionSounds.Length);

        logger.Log($"Sound Index {index}");
        logger.Log($"collisionSounds {collisionSounds.Length}");
        AudioClip collisionAudioClip = collisionSounds[index];

        // TODO: Figure out how to move the collision audio source
        //collisionAudioSource.transform.position = position;
        collisionAudioSource.clip = collisionAudioClip;
        collisionAudioSource.Play();
    }
}
