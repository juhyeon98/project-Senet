using System.Collections.Generic;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    public class StatusConditionFactory
    {
        public Dictionary<EStatusConditionType, IStatusCondition> dataMap;

        public static IStatusCondition MakeStatusCondition(EStatusConditionType type)
        {
            switch(type)
            {
                case EStatusConditionType.Burn:
                    obj = new GameObject(typeof(BurnSO).Name);
                    break;
                case EStatusConditionType.Poision:
                    obj = new GameObject(typeof(PoisionSO).Name);
                    break;
                case EStatusConditionType.Curse:
                    obj = new GameObject(typeof(CurseSO).Name);
                    break;
                case EStatusConditionType.Bleed:
                    obj = new GameObject(typeof(BleedSO).Name);
                    break;
            }
            IStatusCondition result = obj?.GetComponent<IStatusCondition>();
            return result;
        }
    }
}

// TODO
// SO 데이터를 가져와 인스턴스화(new GameObject)
