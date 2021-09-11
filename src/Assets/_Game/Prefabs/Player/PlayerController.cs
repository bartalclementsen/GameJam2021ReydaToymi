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

    private IMessenger message;
    private Core.Loggers.ILogger logger;
    private Rigidbody rigidbody;

    private float minEnginVolumen = 0.3f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        logger = Game.Container.Resolve<Core.Loggers.ILoggerFactory>().Create(this);

        message = Game.Container.Resolve<IMessenger>();
        message.Subscribe<AccelerateXMessage>(HandleMessage);
        message.Subscribe<AccelerateYMessage>(HandleMessage);
        message.Subscribe<AccelerateZMessage>(HandleMessage);

        engineAudioSource.volume = minEnginVolumen;
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

        float velocityFactor = Mathf.Max(0, Mathf.Min(1, sqrMagnitude / newVelocity.sqrMagnitude));
        float engineVolume = (1 - minEnginVolumen) * velocityFactor;
        
        engineAudioSource.volume = minEnginVolumen + engineVolume;
        if(engineAudioSource.volume == float.NaN)
        {
            engineAudioSource.volume = minEnginVolumen;
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
}
