using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(StatManager))]
public class StatusConditionManager : MonoBehaviour
{
    #region Field
    private StatManager m_statManager;
    private Dictionary<EStatusConditionType, IStatusCondition> m_currentStatusCondition = new Dictionary<EStatusConditionType, IStatusCondition>(); 
    #endregion

    #region Methods
    public void Initialize() => m_currentStatusCondition.Clear();

    public void AddStatusCondition(EStatusConditionType type)
    {
        if (m_currentStatusCondition.ContainsKey(type))
        {
            m_currentStatusCondition[type].End();
        }

        switch(type)
        {
            case EStatusConditionType.BURN:
                break;
            case EStatusConditionType.POISION:
                break;
            case EStatusConditionType.CURSE:
                break;
            case EStatusConditionType.BLEED:
                break;
        }
        m_currentStatusCondition[type].Begin();
    }

    public void UpdateStatusCondition()
    {
        foreach (var statusCondition in m_currentStatusCondition.Values)
        {
            if (statusCondition?.During == 0)
            {
                statusCondition?.End();
                m_currentStatusCondition.Remove(statusCondition.Type);
                continue;
            }
            statusCondition.Update();
        }
    }

    public void RemoveStatusCondition(EStatusConditionType type)
    {
        if (m_currentStatusCondition.ContainsKey(type))
        {
            m_currentStatusCondition[type].End();
            m_currentStatusCondition.Remove(type);
        }
    }
    #endregion

    private void Awake()
    {
        m_statManager = GetComponent<StatManager>();
        Initialize();
    }
}
