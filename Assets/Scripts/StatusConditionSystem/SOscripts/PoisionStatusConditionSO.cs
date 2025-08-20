using Juhyeon.Units;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    [CreateAssetMenu(fileName = "Poision", menuName = "Scriptable Objects/Status Condition/Poision")]
    public class PoisionStatusConditionSO : ScriptableObject, IStatusConditionSO
    {
        public string name;
        public string description;
        public uint during;
        public uint damage;

        public IStatusCondition CreateStatusCondition(IAttackable target)
        {
            return new PoisionStatusCondition(target, during, damage);
        }
    }
}
