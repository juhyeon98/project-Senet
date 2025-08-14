using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    public class StatusConditionFactory
    {
        public static IStatusCondition MakeStatusCondition(EStatusConditionType type)
        {
            switch(type)
            {
                case EStatusConditionType.Burn:
                    break;
                case EStatusConditionType.Poision:
                    break;
                case EStatusConditionType.Curse:
                    break;
                case EStatusConditionType.Bleed:
                    break;
            }
            return null;
        }
    }
}

// TODO
// - 각 상태 이상 구현
