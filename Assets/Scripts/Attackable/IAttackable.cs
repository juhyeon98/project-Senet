using UnityEngine;

[RequireComponent(typeof(MovementController), typeof(StatManager), typeof(StatusConditionManager))]
public interface IAttackable
{
    ActivateData Attack();

    void Damage(ActivateData data);
    void OnDead();
}
