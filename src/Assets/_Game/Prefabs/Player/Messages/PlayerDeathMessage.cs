using Core.Mediators;

public enum PlayerDeathType
{
    Unknown,
    Collisions,
    Time
}

internal class PlayerDeathMessage : IMessage
{
    public PlayerDeathType Type { get; }

    public PlayerDeathMessage(PlayerDeathType type)
    {
        Type = type;
    }
}