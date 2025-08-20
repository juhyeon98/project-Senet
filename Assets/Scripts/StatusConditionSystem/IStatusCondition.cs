
using Juhyeon.Units;

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

        uint During { get; }

        void Begin(IAttackable target);

        void Update();

        void End();
    }
}
