using Juhyeon.Behaviour;
using Juhyeon.StatSystem;
using Juhyeon.StatusConditionSystem;

namespace Juhyeon.Units
{
    public interface IAttackable : IUnit
    {
        MovementController MovementController { get; }
        
        StatManager StatManager { get; }
        
        StatusConditionManager StatusConditionManager { get; }
        
        float CurrentAP { get; }
        
        float CurrentMOV { get; }
        
        float ATK { get; }

        void Attack(IAttackable target);

        void Damage(float atk);

        void Heal(float value);

        void Dead();
    }
}
