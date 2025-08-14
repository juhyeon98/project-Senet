using UnityEngine;

namespace Juhyeon.Attackable
{
    [RequireComponent(typeof(MovementController), typeof(StatManager), typeof(StatusConditionManager))]
    public interface IAttackable
    {
        ActivateData Attack();

        void Damage(ActivateData data);
        
        void ApplyEffect(ActivateData data);

        void OnDead();
    }
}
