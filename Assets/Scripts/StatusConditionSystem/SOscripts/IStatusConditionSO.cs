using Juhyeon.Units;

namespace Juhyeon.StatusConditionSystem
{
    public interface IStatusConditionSO
    {
        IStatusCondition CreateStatusCondition(IAttackable target);
    }
}
