using UnityEngine;

public class Poision : IStatusCondition
{
    private StatManager m_stat;
    private const uint DURING = 10;
    private const float DAMAGE = 0.3f;

    public EStatusConditionType Type { get; private set; } = EStatusConditionType.POISION;

    public uint During { get; set; } = DURING;

    public Poision(StatManager statManager)
    {
        m_stat = statManager;
    }

    public void Begin()
    {
    }

    public void Update()
    {
        m_stat?.UpdateHP(DAMAGE);
        During--;
    }

    public void End()
    {
    }
}
