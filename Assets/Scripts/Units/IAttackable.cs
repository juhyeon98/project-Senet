using Juhyeon.Behaviour;
using Juhyeon.StatSystem;
using Juhyeon.StatusConditionSystem;

namespace Juhyeon.Units
{
    public interface IAttackable : IUnit
    {
        MovementController Controller { get; }
        
        StatManager Stat { get; }
        
        StatusConditionManager StatusCondition{ get; }
        
        float CurrentAP { get; }
        
        float CurrentMOV { get; }
        
        float CurrentATK { get; }

        void Attack(IAttackable target);

        void Damage(float atk);

        void Heal(float value);

        void Dead();
    }
}
