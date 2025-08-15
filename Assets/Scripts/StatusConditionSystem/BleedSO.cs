using Juhyeon.Attackable;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    [CreateAssetMenu(fileName = "Bleed", menuName = "Scriptable Objects/Status Condition/Bleed")]
    public class BleedSO : ScriptableObject, IStatusCondition
    {
        public IAttackable Target { get; private set; }

        public EStatusConditionType Type { get; private set; } = EStatusConditionType.Bleed;

        public uint Count { get; private set; } = 0;

        public uint Damage { get; set; }

        public void Begin(IAttackable target)
        {
            Target = target;
            if (Random.Range(0, 3) == 0)
            {
                Damage = (uint)(target.GetHP() * 0.9);
            }
            target.Damage(Damage);
        }

        public void Update()
        {
        }

        public void End()
        {
        }
    }
}
