using UnityEngine;

namespace Juhyeon.StageSystem
{
    public class StageManager : MonoBehaviour
    {
        private PlayerManager m_playerManager;
        private MonsterManager m_monsterManager;
        private Stage m_stage;

        public void Initialize()
        {
            m_playerManager.Initialize();
            m_monsterManager.Initialize();
            m_stage.Initialize();
        }

        public void Reset()
        {
            m_playerManager.Reset();
            m_monsterManager.Reset();
            m_stage.Reset();
        }
    }
}
