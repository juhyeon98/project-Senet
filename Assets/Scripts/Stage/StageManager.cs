using Juhyeon.Units;
using UnityEngine;

namespace Juhyeon.StageSystem
{
    public class StageManager : MonoBehaviour
    {
        private PlayerManager m_playerManager;
        private MonsterManager m_monsterManager;
        private Stage m_stage;

        private void Awake()
        {
            if (m_playerManager == null)
            {
                m_playerManager = FindFirstObjectByType<PlayerManager>();
                if (m_playerManager == null)
                {
                    var manager = new GameObject(typeof(PlayerManager).Name);
                    m_playerManager = manager.AddComponent<PlayerManager>();
                }
            }

            if (m_monsterManager == null)
            {
                m_monsterManager = FindFirstObjectByType<MonsterManager>();
                if (m_playerManager == null)
                {
                    var manager = new GameObject(typeof(MonsterManager).Name);
                    m_monsterManager = manager.AddComponent<MonsterManager>();
                }
            }

            if (m_stage == null)
            {
                m_stage = FindFirstObjectByType<Stage>();
                if (m_stage == null)
                {
                    var manager = new GameObject(typeof(Stage).Name);
                    m_stage = manager.AddComponent<Stage>();
                }
            }
        }

        public void Reset()
        {
            m_playerManager.Reset();
            m_monsterManager.Reset();
            m_stage.Reset();
        }
    }
}
