using Juhyeon.Units;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    [CreateAssetMenu(fileName = "Bleed", menuName = "Scriptable Objects/Status Condition/Bleed")]
    public class BleedSO : ScriptableObject, IStatusCondition
    {
        public IAttackable Target { get; private set; }

        public EStatusConditionType Type { get; private set; } = EStatusConditionType.Bleed;

        public uint During { get; private set; } = 1;

        public uint Damage { get; set; }

        public void Begin(IAttackable target)
        {
            Target = target;
            if (Random.Range(0, 3) == 0)
            {
                Damage = (uint)(target.Stat.CurrentHP * 0.9);
            }
            Target.Damage(Damage);
        }

        public void Update()
        {
        }

        public void End()
        {
        }
    }
}
