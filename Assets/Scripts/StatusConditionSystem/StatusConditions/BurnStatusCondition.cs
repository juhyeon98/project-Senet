using Juhyeon.Units;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    public class BurnStatusCondition : IStatusCondition
    {
        public IAttackable Target { get; private set; }

        public EStatusConditionType Type { get; private set; } = EStatusConditionType.Burn;

        public uint During { get; private set; }

        public float Damage { get; private set; }

        public BurnStatusCondition(IAttackable target, uint during, float damage)
        {
            Target = target;
            During = during;
            Damage = damage;
        }

        public void Begin() { }

        public void Update()
        {
            Target.Damage(Damage);
            During--;
        }

        public void End() { }
    }
}
