using Juhyeon.Units;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    public class BleedStatusCondition : IStatusCondition
    {
        private float m_damage;

        public IAttackable Target { get; private set; }

        public EStatusConditionType Type { get; private set; } = EStatusConditionType.Bleed;

        public uint During { get; private set; } = 1;

        public BleedStatusCondition(IAttackable target)
        {
            Target = target;
        }

        public void Begin()
        {
            if (Random.Range(0, 3) == 0)
            {
                m_damage = Target.Stat.CurrentHP * 0.9f;
            }
            else
            {
                m_damage = Target.Stat.CurrentHP / 2;
            }
        }

        public void Update()
        {
            Target.Damage(m_damage);
            During = 0;
        }

        public void End() { }
    }
}

