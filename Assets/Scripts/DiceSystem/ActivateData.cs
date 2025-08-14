using System.Collections.Generic;
using UnityEngine;
using Juhyeon.Attackable;
using Juhyeon.StatSystem;
using Juhyeon.StatusConditionSystem;

public class ActivateData
{
    public IAttackable Target { get; private set; }
    
    public Dictionary<EStatType, int> Value { get; private set; }

    public IStatusCondition NullableStatusCondition { get; private set; }

    public ActivateData(IAttackable target, Dictionary<EStatType, int> value, IStatusCondition statusCOndition)
    {
        Target = target;
        Value = value;
        NullableStatusCondition = statusCOndition;
    }
}
