using Juhyeon.StatusConditionSystem;
using UnityEngine;

namespace Juhyeon.Units
{
    public class PoisionPuddle : MonoBehaviour, IInteractable
    {
        public void Interact(IAttackable target)
        {
            target.SetHalfMOV();
            target.StatusCondition.AddStatusCondition(EStatusConditionType.Poision);
        }
    }
}
