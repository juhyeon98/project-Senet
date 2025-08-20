using Juhyeon.Units;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    [CreateAssetMenu(fileName = "Poision", menuName = "Scriptable Objects/Status Condition/Poision")]
    public class PoisionSO : ScriptableObject, IStatusCondition
    {
        public uint during;
        public uint damage;

        public IAttackable Target { get; private set; }
        public EStatusConditionType Type { get; private set; } = EStatusConditionType.Poision;

        public uint During { get; private set; }

        public uint Damage { get; private set; }

        public void Begin(IAttackable target)
        {
            Target = target;
            During = during;
            Damage = damage;
        }

        public void Update()
        {
            Target.Damage(Damage);
            During--;
        }

        public void End()
        {
        }
    }
}
