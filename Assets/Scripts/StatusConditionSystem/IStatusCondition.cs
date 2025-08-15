using UnityEngine;
using Juhyeon.Attackable;

namespace Juhyeon.StatusConditionSystem
{
    public enum EStatusConditionType
    {
        Burn, Poision, Curse, Bleed
    }

    public interface IStatusCondition
    {
        IAttackable Target { get; }

        EStatusConditionType Type { get; }

        uint Count { get; }

        uint Damage { get; }

        void Begin(IAttackable target);

        void Update();

        void End();
    }
}
