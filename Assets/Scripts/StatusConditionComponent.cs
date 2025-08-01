using UnityEngine;

namespace Juhyeon.Actor
{
    public enum EStatusCondition
    {
        None
    }

    public class StatusConditionComponent : MonoBehaviour
    {
        private EStatusCondition m_statusCondition = EStatusCondition.None;

        public EStatusCondition Condition => m_statusCondition;

        public void SetStatusCondition(EStatusCondition statusCondition) => m_statusCondition = statusCondition;

        // ApplyStatusCondition ¡¶¿€
    }
}
