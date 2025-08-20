using UnityEngine;

namespace Juhyeon.Units
{
    public class PlayerManager : MonoBehaviour
    {
        private Player m_player;

        private void Awake()
        {
            if (m_player == null)
            {
                m_player = FindFirstObjectByType<Player>();
                if (m_player == null)
                {
                    var player = new GameObject(typeof(Player).Name);
                    m_player = player.AddComponent<Player>();
                }
            }
            m_player.Controller.SetStartPosition();
            m_player.Stat.Initialize();
            m_player.StatusCondition.RemoveAll();
        }

        public void Reset()
        {
            m_player.Controller.SetStartPosition();
            m_player.StatusCondition.RemoveAll();
        }
    }
}
