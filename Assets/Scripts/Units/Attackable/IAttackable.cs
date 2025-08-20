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

        void Attack(IAttackable target);

        void Damage(float atk);

        void Heal(float value);

        void Dead();
    }
}
