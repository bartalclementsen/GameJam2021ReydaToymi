using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlaceholderControls : MonoBehaviour
{
    [SerializeField]
    private Slider leftRightSlider;

    [SerializeField]
    private Slider forwardBackSlider;
    
    [SerializeField]
    private Slider upDownSlider;

    private Core.Loggers.ILogger logger;

    private Core.Mediators.IMessenger messenger;

    void Start()
    {
        logger = Game.Container.Resolve<Core.Loggers.ILoggerFactory>().Create(this);
        messenger = Game.Container.Resolve<Core.Mediators.IMessenger>();
    }

    private void FixedUpdate()
    {
        if(upDownSlider.value != 0)
        {
            messenger.Publish(new AccelerateYMessage(upDownSlider.value));
        }
        if (leftRightSlider.value != 0)
        {
            messenger.Publish(new AccelerateXMessage(leftRightSlider.value));
        }
        if (forwardBackSlider.value != 0)
        {
            messenger.Publish(new AccelerateZMessage(forwardBackSlider.value));
        }
    }
    void Update()
    {
        //SNAP BACK ON RELEAS

    }
}
