namespace Content.Shared._Goobstation.Penetration;

/// <summary>
/// This penetratable component determine how many "penetration health" projectile requires to penetrate object.
/// </summary>
[RegisterComponent]
public sealed partial class PenetratableComponent : Component
{
    /// <summary>
    /// How much "penetration health" this entity will consume from projectile on penetration
    /// </summary>
    [DataField]
    public float PenetrateDamage = 25f;

    /// <summary>
    /// How much damage will be reduced for penetration.
    /// 100 damage projectile with 10% penalty will deal 90 damage if it penetrate this entity
    /// </summary>
    [DataField("damagePenalty")]
    public float DamagePenaltyModifier = 0f;
}
