using Juhyeon.Units;

namespace Juhyeon.StatusConditionSystem
{
    public class PoisionStatusCondition : IStatusCondition
    {
        public IAttackable Target { get; private set; }

        public EStatusConditionType Type { get; private set; } = EStatusConditionType.Poision;

        public uint During { get; private set; }

        public float Damage { get; private set; }

        public PoisionStatusCondition(IAttackable target, uint during, float damage)
        {
            Target = target;
            During = during;
            Damage = damage;
        }

        public void Begin() { }

        public void Update()
        {
            Target.Damage(Damage);
            During--;
        }

        public void End() { }
    }
}
