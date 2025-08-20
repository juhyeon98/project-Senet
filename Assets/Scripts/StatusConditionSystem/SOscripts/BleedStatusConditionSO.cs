using Juhyeon.Units;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    [CreateAssetMenu(fileName = "Bleed", menuName = "Scriptable Objects/Status Condition/Bleed")]
    public class BleedStatusConditionSO : ScriptableObject, IStatusConditionSO
    {
        public new string name;
        public string description;
        
        public IStatusCondition CreateStatusCondition(IAttackable target)
        {
            return new BleedStatusCondition(target);
        }
    }
}
