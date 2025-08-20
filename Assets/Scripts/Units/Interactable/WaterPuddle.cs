using Juhyeon.StatusConditionSystem;
using UnityEngine;

namespace Juhyeon.Units
{
    public class WaterPuddle : MonoBehaviour, IInteractable
    {
        public void Interact(IAttackable target)
        {
            target.Stat.SetHalfMOV();
            target.StatusCondition.RemoveStatus(EStatusConditionType.Burn);
        }
    }
}
