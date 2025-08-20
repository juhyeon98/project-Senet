using Juhyeon.Units;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    [CreateAssetMenu(fileName = "Burn", menuName = "Scriptable Objects/Status Condition/Burn")]
    public class BurnStatusConditionSO : ScriptableObject, IStatusConditionSO
    {
        public string name;
        public string description;
        public uint during;
        public uint damage;

        public IStatusCondition CreateStatusCondition(IAttackable target)
        {
            return new BurnStatusCondition(target, during, damage);
        }
    }
}
