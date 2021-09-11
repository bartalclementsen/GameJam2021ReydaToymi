using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class AccelerateMessage : Core.Mediators.Message
{
    public float Value { get; }

    public AccelerateMessage(float value)
    {
        Value = value;
    }

}
public class AccelerateXMessage : AccelerateMessage
{
    public AccelerateXMessage(float value) : base(value) { }
}

public class AccelerateYMessage : AccelerateMessage
{
    public AccelerateYMessage(float value) : base(value) { }
}

public class AccelerateZMessage : AccelerateMessage
{
    public AccelerateZMessage(float value) : base(value) { }
}

public class PlayerCollided : Core.Mediators.Message
{
    public Collision Collision { get; }

    public PlayerCollided(Collision collision)
    {
        Collision = collision;
    }
}