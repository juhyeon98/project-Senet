public enum EStatusConditionType
{
    BURN, POISION, CURSE, BLEED
}

public interface IStatusCondition
{
    EStatusConditionType Type { get; }

    uint During { get; set; }

    void Begin();

    void Update();

    void End();
}
