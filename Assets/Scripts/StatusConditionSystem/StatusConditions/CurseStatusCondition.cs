using Juhyeon.Units;

namespace Juhyeon.StatusConditionSystem
{
    public class CurseStatusCondition : IStatusCondition
    {
        public IAttackable Target { get; private set; }

        public EStatusConditionType Type { get; private set; } = EStatusConditionType.Curse;

        public uint During { get; private set; }

        public CurseStatusCondition(IAttackable target, uint during)
        {
            Target = target;
            During = during;
        }

        public void Begin() { }

        public void Update()
        {
            // Apply
            During--;
        }

        public void End() { }
    }
}
