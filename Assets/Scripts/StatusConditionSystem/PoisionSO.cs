using Juhyeon.Attackable;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    [CreateAssetMenu(fileName = "Poision", menuName = "Scriptable Objects/Status Condition/Poision")]
    public class PoisionSO : ScriptableObject, IStatusCondition
    {
        public uint count;
        public uint damange;

        public IAttackable Target { get; private set; }

        public EStatusConditionType Type { get; private set; } = EStatusConditionType.Poision;

        public uint Count { get; private set; }

        public uint Damage { get; private set; }

        public void Begin(IAttackable target)
        {
            Target = target;
            Count = count;
            Damage = Damage;
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
