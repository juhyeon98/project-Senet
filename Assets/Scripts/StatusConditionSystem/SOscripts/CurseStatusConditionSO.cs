using Juhyeon.Units;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    [CreateAssetMenu(fileName = "Curse", menuName = "Scriptable Objects/Status Condition/Curse")]
    public class CurseStatusConditionSO : ScriptableObject, IStatusConditionSO
    {
        public string name;
        public string description;
        public uint during;

        public IStatusCondition CreateStatusCondition(IAttackable target)
        {
            return new CurseStatusCondition(target, during);
        }
    }
}