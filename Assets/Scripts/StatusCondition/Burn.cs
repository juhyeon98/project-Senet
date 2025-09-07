using UnityEngine;

public class Burn : IStatusCondition
{
    private StatManager m_stat;
    private const uint DURING = 7;
    private const float DAMAGE = 1.3f;

    public EStatusConditionType Type { get; private set; } = EStatusConditionType.BURN;

    public uint During { get; set; } = DURING;

    public Burn(StatManager statManager)
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
