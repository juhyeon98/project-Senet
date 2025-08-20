using Juhyeon.StatSystem;
using System.Collections.Generic;
using UnityEngine;

namespace Juhyeon.Units
{
    public class MonsterManager : MonoBehaviour
    {
        private List<Monster> m_monsters = new List<Monster>();
        public List<StatDataSO> monsterStatDB;

        private void Awake()
        {
            SpwanMonsters();
        }

        public void Reset()
        {
            m_monsters.Clear();
            SpwanMonsters();
        }

        private void SpwanMonsters()
        {
        }
    }
}

// TODO
// 몬스터 스폰