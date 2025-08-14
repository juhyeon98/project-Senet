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

        void Begin();

        void Update();

        void End();
    }
}
