using Juhyeon.Units;
using System.Collections.Generic;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    public class StatusConditionManager : MonoBehaviour
    {
        private Dictionary<EStatusConditionType, IStatusCondition> m_currentStatus = new Dictionary<EStatusConditionType, IStatusCondition> ();

        private void Awake()
        {
            m_currentStatus.Clear();
        }

        public void AddStatusCondition(IStatusCondition statusCondition, IAttackable target)
        {
            m_currentStatus.Add(statusCondition.Type, statusCondition);
            statusCondition?.Begin(target);
        }

        public void UpdateStatusCondition()
        {
            if (m_currentStatus.Count == 0) return;
            foreach (var statusCondition in m_currentStatus.Values)
            {
                if (statusCondition.During == 0)
                {
                    m_currentStatus.Remove(statusCondition.Type);
                    continue;
                }
                statusCondition?.Update();
            }
        }
    }
}
