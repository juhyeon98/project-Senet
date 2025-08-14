using System.Collections.Generic;
using UnityEngine;

namespace Juhyeon.StatSystem
{
    public class StatManager : MonoBehaviour
    {
        #region Fields
        private Dictionary<EStatType, int> m_originStats;
        private Dictionary<EStatType, int> m_currentStats;

        public StatDataSO statData;
        #endregion

        #region Stat Manager Methods
        public int? GetCurrentStatValue(EStatType statType) => GetValue(m_currentStats, statType);

        public int? GetOriginStatValue(EStatType statType) => GetValue(m_originStats, statType);

        private static int? GetValue(Dictionary<EStatType, int> db, EStatType type)
        {
            if (db.ContainsKey(type))
            {
                return db[type];
            }
            return null;
        }

        public void UpdateCurrentStatValue(EStatType statType, int value) => UpdateValue(m_currentStats, statType, value);

        public void UpdateOriginStatValue(EStatType statType, int value) => UpdateValue(m_originStats, statType, value);

        private static void UpdateValue(Dictionary<EStatType, int> db, EStatType type, int value)
        {
            if (db.ContainsKey(type))
            {
                db[type] += value;
            }
        }
        #endregion

        private void Awake()
        {
            m_originStats = new Dictionary<EStatType, int>
            {
                { EStatType.HP, statData.HP },
                { EStatType.AP, statData.AP },
                { EStatType.MOV, statData.MOV },
                { EStatType.ATK, statData.ATK }
            };
            m_currentStats = new Dictionary<EStatType, int>(m_originStats);
        }
    }
}
