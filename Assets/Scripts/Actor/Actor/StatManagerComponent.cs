using System.Collections.Generic;
using UnityEngine;

namespace Juhyeon.Actor
{
    public enum EStatType
    {
        HP, AP, ATK, MOV
    }

    public class StatManagerComponent : MonoBehaviour
    {
        public Juhyeon.SO.StatDataScriptableObject statData;
        private Dictionary<EStatType, int> m_statDB = new Dictionary<EStatType, int>();

        private void Awake()
        {
            m_statDB.Clear();
            m_statDB[EStatType.HP] = (int)statData.HP;
            m_statDB[EStatType.AP] = (int)statData.AP;
            m_statDB[EStatType.ATK] = (int)statData.ATK;
        }

        public void InitializeMOV()
        {
            m_statDB[EStatType.MOV] = 1;
        }

        public void ApplyStat(EStatType type, int value)
        {
            if (m_statDB.ContainsKey(type))
            {
                int statValue = m_statDB[type];
                statValue += value;
                m_statDB[type] = statValue;
            }
        }

        public int GetStatValue(EStatType type) => m_statDB[type];
    }
}
