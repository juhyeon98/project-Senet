using Juhyeon.SO;
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
            var playerStat = statData as PlayerStatDataScriptableObject;
            if (playerStat != null)
            {
                m_statDB[EStatType.MOV] = (int)playerStat.MOV;
            }

            // test
            var player = statData as PlayerStatDataScriptableObject;
            if (playerStat != null)
            {
                Debug.Log($"Player HP : {player.HP}");
                Debug.Log($"Player AP : {player.AP}");
                Debug.Log($"Player MOV : {player.MOV}");
                Debug.Log($"Player ATK : {player.ATK}");
            }
            var monster = statData as MonsterDataScriptableObject;
            if (monster != null)
            {
                Debug.Log($"{monster.name} HP : {monster.HP}");
                Debug.Log($"{monster.name}.AP : {monster.AP}");
                Debug.Log($"{monster.name} ATK : {monster.ATK}");
            }
        }

        public void InitializeMOV()
        {
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

        public IEnumerable<(EStatType type, int value)> GetStatValue()
        {
            foreach (var item in m_statDB)
            {
                yield return (item.Key, item.Value);
            }
        }
    }
}
