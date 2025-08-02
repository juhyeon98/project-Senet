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
        // Stat Scriptable Object 참조 추가
        private Dictionary<EStatType, int> m_statDB = new Dictionary<EStatType, int>();

        private void Awake()
        {
            // Scriptable Object를 DB로 이동
        }

        public void ApplyStat(EStatType type, int value)
        {
            int statValue = m_statDB[type];
            statValue += value;
            m_statDB[type] = statValue;
        }

        public int GetStatValue(EStatType type) => m_statDB[type];
    }
}
