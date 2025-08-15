using Juhyeon.Attackable;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    [CreateAssetMenu(fileName = "Curse", menuName = "Scriptable Objects/Status Condition/Curse")]
    public class CurseSO : ScriptableObject, IStatusCondition
    {
        public uint count;

        public IAttackable Target { get; private set; }

        public EStatusConditionType Type { get; private set; } = EStatusConditionType.Curse;

        public uint Count { get; private set; }

        public uint Damage { get; private set; } = 0;

        public void Begin(IAttackable target)
        {
            Target = target;
            Count = count;
        }

        public void Update()
        {
            // apply
            Count--;
        }

        public void End()
        {
        }
    }
}

// TODO
// - 효과 무효화 생각해보기