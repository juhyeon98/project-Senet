using Juhyeon.Attackable;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    [CreateAssetMenu(fileName = "Burn", menuName = "Scriptable Objects/Status Condition/Burn")]
    public class BurnSO : ScriptableObject, IStatusCondition
    {
        public uint count;
        public uint damage;

        public IAttackable Target { get; private set; }

        public EStatusConditionType Type { get; private set; } = EStatusConditionType.Burn;

        public uint Count { get; private set; }

        public uint Damage { get; private set; }

        public void Begin(IAttackable target)
        {
            Target = target;
            Count = count;
            Damage = damage;
        }

        public void Update()
        {
            Target.Damage(Damage);
            Count--;
        }

        public void End()
        {
        }
    }
}
