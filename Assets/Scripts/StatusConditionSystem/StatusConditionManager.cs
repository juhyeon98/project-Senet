using Juhyeon.Attackable;
using System.Collections.Generic;
using UnityEngine;

namespace Juhyeon.StatusConditionSystem
{
    public class StatusConditionManager : MonoBehaviour
    {
        private Dictionary<EStatusConditionType, IStatusCondition> m_currentStatusConditions = new Dictionary<EStatusConditionType, IStatusCondition>();

        public void AddStatusCondition(IStatusCondition statusCondition, IAttackable target)
        {
            if (!m_currentStatusConditions.ContainsKey(statusCondition.Type))
            {
                m_currentStatusConditions.Add(statusCondition.Type, statusCondition);
            }
            else
            {
                m_currentStatusConditions[statusCondition.Type] = statusCondition;
            }
            statusCondition.Begin(target);
        }

        public void UpdateStatusCondition()
        {
            foreach (var statusCondition in m_currentStatusConditions.Values)
            {
                statusCondition.Update();

                if (statusCondition.Count == 0)
                {
                    statusCondition.End();
                    m_currentStatusConditions.Remove(statusCondition.Type);
                }
            }
        }
    }
}
